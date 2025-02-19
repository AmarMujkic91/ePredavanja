using eGostujucaPredavanja.Services.Database;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services
{
    public class PositionsService : IPositionsService
    {
        public eGostujucaPredavanjaContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }

        public PositionsService(eGostujucaPredavanjaContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<object> GetAllPositions()
        {
            var positions = _dbContext.Positions.ToList();
            List<object> result = new List<object>();
            result.Add(positions);

            return result;
        }
    }
}
