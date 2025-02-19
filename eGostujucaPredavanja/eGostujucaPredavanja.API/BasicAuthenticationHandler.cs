using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace eGostujucaPredavanja.API
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        IUsersService _usersService;

        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IUsersService usersService) : base(options, logger, encoder, clock)
        {
            _usersService = usersService;   
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Missing header");
            }


            var autHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
            var credentialsBytes = Convert.FromBase64String(autHeader.Parameter);
            var credentials = Encoding.UTF8.GetString(credentialsBytes).Split(':');

            var username = credentials[0];
            var password = credentials[1];

            var user = _usersService.Login(username, password);

            if(user == null)
            {
                return AuthenticateResult.Fail("Auth Failed");
            }
            else
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.Firstname),
                    new Claim(ClaimTypes.NameIdentifier,user.UserName)
                };

                //vraca istu svih pozivija koji korisnik ima
                foreach(var role in user.UserPositions)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Position.Name));
                }

                var identity = new ClaimsIdentity(claims, Scheme.Name);

                var principal = new ClaimsPrincipal(identity);

                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
        }

    }
}
