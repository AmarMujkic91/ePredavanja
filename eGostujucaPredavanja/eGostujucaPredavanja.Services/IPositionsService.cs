using eGostujucaPredavanja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public interface IPositionsService
    {
        public List<object> GetAllPositions();
    }
}
