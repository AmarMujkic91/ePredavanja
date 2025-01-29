using eGostujucaPredavanja.Model;
using eGostujucaPredavanja.Model.Requests;
using eGostujucaPredavanja.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public interface IUsersService : ICRUDService<Model.Users,UsersSearchObject,UsersInsertRequests,UsersUpdateRequests>
    {
        //PagedResult<Model.Users> GetList(UsersSearchObject searchObject);

        //Users Insert(UsersInsertRequests request);

        //Users Update(int id, UsersUpdateRequests request);

        Model.Users Login(string username, string password);
    }
}
