using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;

namespace eGostujucaPredavanja.Services
{
    public interface IEventsService: ICRUDService<Events, EventsSearchObject, EventsUpsertRequests, EventsUpsertRequests>
    {
        //List<Events>GetList(EventsSearchObject searchObject); Umjestdo da deklarisemo ovdje IEventsService naslijeduje IService al mu proslijeduujemo kojim modelom i search objektom ce radit 

        public Events Activate(int id);
        public Events Hide(int id);
        public Events Edit(int id);
        public List<string> AllowedActions(int id);
    }
}