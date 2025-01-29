using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsersController : BaseCRUDController<Model.Users,UsersSearchObject,UsersInsertRequests,UsersUpdateRequests>
    {
        public UsersController(IUsersService services) : base(services)
        {
        }
    }
}
