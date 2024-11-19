using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model
{
    public class Positions
    {
        public int PositionId { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}
