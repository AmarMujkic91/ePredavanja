using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.EventsStateMachine
{
    public class InitialEventState : BaseEventState
    {
        public InitialEventState(eGostujucaPredavanjaContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Events Insert(EventsUpsertRequests requests)
        {
            //V1 Moja

            //Events entity = new Events();
            //_mapper.Map(requests, entity);

            //entity.StateMachine = "draft";

            //_dbContext.Add(entity);
            //_dbContext.SaveChanges();
            //return _mapper.Map<Model.Events>(entity);


            //V2 Asistent

            //var set = _dbContext.Set<Events>();
            //var entity = _mapper.Map<Events>(requests);

            //entity.StateMachine = "draft";

            //set.Add(entity);
            //_dbContext.SaveChanges();
            //return _mapper.Map<Model.Events>(entity);

            //V3 Moja

            var entity = _mapper.Map<Events>(requests);

            entity.StateMachine = "draft";

            _dbContext.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<Model.Events>(entity);
        }

        public override List<string> AllowedActions(Events entity)
        {
            return new List<string>() { nameof(Insert) };
        }

    }
}
