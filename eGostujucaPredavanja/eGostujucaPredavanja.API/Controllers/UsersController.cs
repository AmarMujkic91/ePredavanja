using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsersController : ControllerBase
    {
        protected IUsersService _services;

        public UsersController(IUsersService services)
        {
            _services = services;
        }

        [HttpGet]
        public virtual PagedResult<Users> GetList([FromQuery]UsersSearchObject searchObject)
        {
            return _services.GetList(searchObject);
        }

        [HttpPost]
        public virtual Users Insert(UsersInsertRequests request)
        {
            return _services.Insert(request);
        }

        [HttpPut("{id}")]
        public virtual Users Update(int id, UsersUpdateRequests request) {
            return _services.Update(id,request);
        }
    }
}
