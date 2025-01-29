using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : BaseCRUDController<Model.Events, EventsSearchObject, EventsUpsertRequests, EventsUpsertRequests>
    {
        public EventsController(IEventsService service) : base(service)
        {

        }

        [HttpPut("{id}/activate")]
        public Events Activate(int id)
        {
            return (_service as IEventsService).Activate(id);
        }

        [HttpPut("{id}/edit")]
        public Events Edit(int id)
        {
            return (_service as IEventsService).Edit(id);
        }

        [HttpPut("{id}/hide")]
        public Events Hide(int id)
        {
            return (_service as IEventsService).Hide(id);
        }

        [HttpGet("{id}/allowedActions")]
        public List<string> AllowedActions(int id)
        {
            return (_service as IEventsService).AllowedActions(id);
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
