using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<TModel, TSearch> : ControllerBase where TSearch : BaseSearchObject
    {
        protected IService<TModel, TSearch> _service;

        public BaseController(IService<TModel, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public virtual PagedResult<TModel> GetList([FromQuery] TSearch searchObject)
        {
            return _service.GetList(searchObject);
        }
    }
}
