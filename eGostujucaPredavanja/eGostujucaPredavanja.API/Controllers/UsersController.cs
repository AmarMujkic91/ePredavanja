using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Services.Database;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsersController : BaseCRUDController<Model.Users,UsersSearchObject,UsersInsertRequests,UsersUpdateRequests>
    {
        public UsersController(IUsersService services) : base(services)
        {
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public Model.Users Login(string username, string password)
        {
            return (_service as IUsersService).Login(username,password);
        }
    }
}
