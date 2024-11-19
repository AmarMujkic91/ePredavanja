using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public class BaseService<TModel, TSearch, TDbEntity> : IService<TModel, TSearch> where TModel : class where TSearch : BaseSearchObject where TDbEntity : class
    {
        public eGostujucaPredavanjaContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }

        public BaseService(eGostujucaPredavanjaContext dbContext,IMapper mapper) 
        { 
            _dbContext = dbContext; 
            _mapper = mapper;
        }

        public TModel GetById(int id)
        {
            var entity = _dbContext.Set<TDbEntity>().Find(id);
            if (entity != null)
            {
                return _mapper.Map<TModel>(entity);
            }
            else
            {
                return null;
            }
        }

        public Model.PagedResult<TModel> GetList(TSearch search)
        {
            var query = _dbContext.Set<TDbEntity>().AsQueryable();

            int count = query.Count();

            query = AddFilter(search,query);

            if(search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                query = query.Skip(search.PageSize.Value * search.Page.Value).Take(search.PageSize.Value);
            }

            var list = query.ToList();

            List<TModel> result = new List<TModel>();

            result = _mapper.Map(list, result);

            PagedResult<TModel> pagedResult = new PagedResult<TModel>();
            pagedResult.ResultList = result;  
            pagedResult.Count= count;

            return pagedResult;
        }

        public IQueryable<TDbEntity> AddFilter(TSearch search, IQueryable<TDbEntity> query)
        {
            return query;
        }

    }
}
