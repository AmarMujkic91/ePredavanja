using eGostujucaPredavanja.Services;
using eGostujucaPredavanja.Services.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGostujucaPredavanja.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PositionsController : ControllerBase
    {
        protected IPositionsService _service;

        public PositionsController(IPositionsService service)
        {
            _service = service;
        }

    
        [HttpGet]
        public List<object> GetAllPositions()
        {
            return _service.GetAllPositions();
        }
    }
}
