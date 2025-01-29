using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.EventsStateMachine
{
    public class BaseEventState
    {
        public eGostujucaPredavanjaContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }
        public IServiceProvider _serviceProvider { get; set; }

        public BaseEventState(eGostujucaPredavanjaContext dbContext, IMapper mapper, IServiceProvider serviceProvider) //Instanciramo 
        {   //Mapiramo
            _dbContext = dbContext;
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        //Stanja u kojem Event moze bit su : initial, draft, active, hidden

        //Navodimo sve moguce opcije Insert,Update, Activate i Hide
        public virtual Model.Events Insert(EventsUpsertRequests requests)
        {
            throw new UserException("Meethod not Allowed");
        }

        public virtual Model.Events Update(int id, EventsUpsertRequests requests)
        {
            throw new UserException("Method not Allowed");
        }

        public virtual Model.Events Activate(int id)
        {
            throw new UserException("Method not Allowed");
        }

        public virtual Model.Events Hide(int id)
        {
            throw new UserException("Method not Allowed");
        }

        public virtual Model.Events Edit(int id)
        {
            throw new UserException("Method not Allowed");
        }

        //PSalje UI podatke koja dugmad da budu vidljiva ovisno od satnja u kojem se pbjekat nalazai i to overajdamo u svakoj izvedenoj klasi.
        public virtual List<string> AllowedActions(Database.Events entity)
        {
            throw new UserException("Method not Allowed");
        }

        //Na osnovu stanja vracamo klasu.
        public BaseEventState CreateState(string stateName)
        {
            switch (stateName) // ovisno  u kojem smo stanju mi istanciramo klasu
            {
                case "initial":
                    return _serviceProvider.GetService<InitialEventState>(); // exctendion metoda! Na postojeci servis dodajemo metodu. 02:27:00
                case "draft":
                    return _serviceProvider.GetService<DraftEventState>();
                case "active":
                    return _serviceProvider.GetService<ActiveEventState>();
                case "hidden":
                    return _serviceProvider.GetService<HiddenEventState>();
                default: throw new Exception("State not recognized");
            }
        }

    }
}
