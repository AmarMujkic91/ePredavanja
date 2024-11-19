using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.SearchObject;

namespace eGostujucaPredavanja.Services
{
    public interface IEventsService: IService<Events, EventsSearchObject>
    {
        //List<Events>GetList(EventsSearchObject searchObject); Umjestdo da deklarisemo ovdje IEventsService naslijeduje IService al mu proslijeduujemo kojim modelom i search objektom ce radit 
    }
}