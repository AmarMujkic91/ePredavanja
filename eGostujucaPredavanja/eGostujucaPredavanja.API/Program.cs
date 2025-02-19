using eGostujucaPredavanja.API;
using eGostujucaPredavanja.API.Filters;
using eGostujucaPredavanja.Services;
using eGostujucaPredavanja.Services.Database;
using eGostujucaPredavanja.Services.EventsStateMachine;
using Mapster;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//------------------------------------------------------Deklarisemo stanja u dependenci injeksenu ------------------------------------------------------------------------------
builder.Services.AddTransient<IEventsService, EventsService>();
builder.Services.AddTransient<IUsersService, UsersService>();
builder.Services.AddTransient<IPositionsService, PositionsService>();
//------------------------------------------------------ZA STATE MACHINE--------------------------------------------------------------------------------------------------------
builder.Services.AddTransient<BaseEventState>();
builder.Services.AddTransient<InitialEventState>();
builder.Services.AddTransient<DraftEventState>();
builder.Services.AddTransient<ActiveEventState>();
builder.Services.AddTransient<HiddenEventState>();
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

builder.Services.AddControllers(x =>
{
    x.Filters.Add<ExceptionFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("basicAuth", new
        OpenApiSecurityScheme()
    {
        Type = SecuritySchemeType.Http,
        Scheme = "basic"
    });


    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme()
            {
                Reference = new OpenApiReference{Type = ReferenceType.SecurityScheme, Id = "basicAuth"}
            },
            new string[]{ }
        }
    });

});

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<eGostujucaPredavanjaContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddMapster();

//-------------------------------------------------------ZA AUTHENTIFIKACIJU----------------------------------------------------------------------------------------------------
//Dodaje u .net pipline authentifikaciju 
builder.Services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions,BasicAuthenticationHandler>("BasicAuthentication",null);
//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var daraContext = scope.ServiceProvider.GetRequiredService<eGostujucaPredavanjaContext>();
    daraContext.Database.Migrate();
}

app.Run();
