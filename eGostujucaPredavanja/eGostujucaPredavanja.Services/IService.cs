using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{

    // ovim "where TSearch : BaseSearchObject" garantujemo ko bude implementirqao metodu GetList, minimalno sto ce imat od parametra je  sto sadrzi BaseSearchObject


    public interface IService<TModel, TSearch> where TSearch : BaseSearchObject 
    {
        public PagedResult<TModel> GetList(TSearch search);

        public TModel GetById(int id);
    }
}
