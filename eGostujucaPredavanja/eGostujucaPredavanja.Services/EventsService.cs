using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace eGostujucaPredavanja.Services
{
    public class EventsService : BaseService<Model.Events, EventsSearchObject, Database.Events>, IEventsService
    {
        public EventsService(eGostujucaPredavanjaContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }


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
 