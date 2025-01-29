using eGostujucaPredavanja.Model.SearchObject;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public abstract class BaseCRUDService<TModel, TSearch, TDbEntity, TInsert, TUpdate> 
                          : BaseService<TModel, TSearch, TDbEntity>,
                            ICRUDService<TModel, TSearch, TInsert, TUpdate> where TModel : class where TSearch : BaseSearchObject where TDbEntity : class
    {

        public BaseCRUDService(eGostujucaPredavanjaContext dbContext, IMapper mapper):base(dbContext,mapper) { 

        }

        public virtual TModel Insert(TInsert request)
        {
            //--------------------------------------
            // ne moze 
            // DbEntity entity = new DbEntity(); 
            // jer je "entiy" ABSTRACT i ne moze se inicjalizovati
            // _mapper.Map(request, entity);
            //--------------------------------------

            //Standardni kod za sve: Reguest mapira u entitet 
            TDbEntity entity = _mapper.Map<TDbEntity>(request); 

            // Proslijedujemo request i entitet koji smo inicijalno mapirali 
            // Za insert Usera jer ona ima Salt i Has
            BeforeInsert(request,entity);

            //Standardni kod za sve: dodaj, sacuvaj i vrati
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public virtual void BeforeInsert(TInsert request,TDbEntity entity){}

        public virtual TModel Update(int id, TUpdate request)
        {
            //Instanciramo "set"
            var set = _dbContext.Set<TDbEntity>();

            var entity =set.Find(id);

            _mapper.Map(request, entity);

            BeforUpdate(request,entity);

            _dbContext.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual void BeforUpdate(TUpdate request, TDbEntity entity) { }
    }
}
