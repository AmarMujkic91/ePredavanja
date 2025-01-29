using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services.Database;
using eGostujucaPredavanja.Services.EventsStateMachine;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace eGostujucaPredavanja.Services
{
    public class EventsService : BaseCRUDService<Model.Events, EventsSearchObject, Database.Events, EventsUpsertRequests, EventsUpsertRequests>, IEventsService
    {
        public BaseEventState _baseEventState { get; set; }
        ILogger<EventsService> _logger;

        public EventsService(eGostujucaPredavanjaContext dbContext, IMapper mapper, BaseEventState baseEventState, ILogger<EventsService> logger) : base(dbContext, mapper)
        {
            _baseEventState = baseEventState;
            _logger = logger;
        }
       
        //ovdje umjeto baznog inserta koristimo virtual InitialProizvodi state insert i za to na treba gore u konstruktoru BaseProizvodState
        public override Model.Events Insert(EventsUpsertRequests request)
        {
            var state = _baseEventState.CreateState("initial");  // instanciramo pravu  klasu za to stanje  //ovo smo hard kodali
            return state.Insert(request);   
        }

        public override Model.Events Update(int id, EventsUpsertRequests request)
        {
            var entity = GetById(id); 
            var state = _baseEventState.CreateState(entity.StateMachine);  // instanciramo pravu  klasu za to stanje
            return state.Update(id, request);
        }


        //-------------------------------------------OVE DOLE NE POSTOJE U ICRUDEService PA SE MORAJU IMPLEMENTIRAT U IEventsService----------------------------------------------
        public Model.Events Activate(int id)
        {
            var entity = GetById(id);
            var state = _baseEventState.CreateState(entity.StateMachine); // instanciramo pravu  klasu za to stanje
            return state.Activate(id);
        }

        public Model.Events Hide(int id)
        {
            var entity = GetById(id);
            var state = _baseEventState.CreateState(entity.StateMachine); // instanciramo pravu  klasu za to stanje
            return state.Hide(id);
        }

        public Model.Events Edit(int id)
        {
            var entity = GetById(id);
            var state = _baseEventState.CreateState(entity.StateMachine); // instanciramo pravu  klasu za to stanje
            return state.Edit(id);
        }

        public List<string> AllowedActions(int id)
        {
            _logger.LogInformation($"AllowedActions called for -----------> {id}");
           if(id == 0)
            {
                var state = _baseEventState.CreateState("initial");
                return state.AllowedActions(null);
            }
            else
            {
                var entity = _dbContext.Events.Find(id);
                var state = _baseEventState.CreateState(entity.StateMachine);
                return state.AllowedActions(entity);
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        //public eGostujucaPredavanjaContext _dbContext { get; set; }
        //public IMapper _mapper { get; set; }

        //public EventsService(eGostujucaPredavanjaContext dbContext, IMapper mapper)
        //{
        //    _dbContext = dbContext;
        //    _mapper = mapper;
        //}

        //public virtual PagedResult<Model.Events> GetList(EventsSearchObject searchObject)
        //{
        //    var query = _dbContext.Events.AsQueryable();
        //    var count = query.Count();  

        //    if (!string.IsNullOrWhiteSpace(searchObject?.TitleGTE))
        //    {
        //        query = query.Where(x => x.Title.StartsWith(searchObject.TitleGTE));
        //    }

        //    if (searchObject.StartDate != null)
        //    {
        //        query = query.Where(x => x.StartDate >= searchObject.StartDate);
        //    }
        //    if (searchObject.EndDate != null)
        //    {
        //        query = query.Where(x => x.EndDate <= searchObject.EndDate);
        //    }

        //    var list = query.ToList();

        //    var result = new List<Model.Events>();

        //    result = _mapper.Map(list, result);

        //    PagedResult<Model.Events> pagedResult= new PagedResult<Model.Events>();
        //    pagedResult.ResultList = result;
        //    pagedResult.Count = count;

        //    return pagedResult;
        //}

        //public Model.Events GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
 