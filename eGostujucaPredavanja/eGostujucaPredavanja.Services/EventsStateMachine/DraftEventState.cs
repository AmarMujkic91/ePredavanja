using EasyNetQ;
using eGostujucaPredavanja.Model.Messages;
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
    public class DraftEventState : BaseEventState
    {
        public DraftEventState(eGostujucaPredavanjaContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Events Update(int id, EventsUpsertRequests requests)
        {   
            //V1

            //var set = _dbContext.Set<Events>();

            //var entity = set.Find(id);

            //_mapper.Map(requests, entity);

            //_dbContext.SaveChanges();

            //return _mapper.Map<Model.Events>(entity);

            //V2

            var entity = _dbContext.Events.Find(id);

            _mapper.Map(requests, entity);

            _dbContext.SaveChanges();

            //Kada dode do primjene eventa nekog ubdata moramo javit korisnicima
            //var bus = RabbitHutch.CreateBus("host=localhost:5672");

            //var mappedEntity = _mapper.Map<Model.Events>(entity);

            //EventUpdatet message = new EventUpdatet { eventDetails = mappedEntity };

            //bus.PubSub.Publish(mappedEntity);
            var bus = RabbitHutch.CreateBus("host=localhost:5672");

            var messageEntity = _mapper.Map<Model.Events>(entity);

            EventUpdatet message = new EventUpdatet { EventDetails = messageEntity };

            bus.PubSub.PublishAsync(message);

            return messageEntity;
        }

        public override Model.Events Activate(int id)
        {
            var entity = _dbContext.Events.Find(id);

            entity.StateMachine = "active";

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Events>(entity);
        }

        public override Model.Events Hide(int id)
        {
            var entity = _dbContext.Events.Find(id);

            entity.StateMachine = "hidden";

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Events>(entity);
        }

        public override List<string> AllowedActions(Events entity)
        {
            return new List<string>() { nameof(Update), nameof(Activate), nameof(Hide) };
        }

    }
}
