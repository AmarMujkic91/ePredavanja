using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : BaseController<Model.Events, EventsSearchObject>
    {
        public EventsController(IEventsService service) : base(service)
        {

        }


        //Bez Naslijedenog Base Controler-a

        //protected IEventsService _service;

        //public EventsController(IEventsService service) : base(service)
        //{
        //    _service = service;
        //}


        // ako nema virtual on poziva baznu klasu ako imamo u izvedenoj ima funkcija istog imena tamo ide override
        //[HttpGet]
        //public virtual PagedResult<Events> GetList([FromQuery]EventsSearchObject searchObject)
        //{
        //    return _service.GetList(searchObject);
        //}
    }
}
