using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.EventsStateMachine
{
    public class HiddenEventState : BaseEventState
    {
        public HiddenEventState(eGostujucaPredavanjaContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Events Edit(int id)
        {
            var entity = _dbContext.Events.Find(id);

            entity.StateMachine = "draft";

            _dbContext.SaveChanges();

            return _mapper.Map<Model.Events>(entity);   
        }

        public override List<string> AllowedActions(Events entity)
        {
            return new List<string>(){ nameof(Edit)};
        }
    }
}
