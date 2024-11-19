using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model
{
    public class UserPositions
    {
        public int UserPositionId { get; set; }

        public int UserId { get; set; }

        public int PositionId { get; set; }

        public DateTime DateOfChanges { get; set; }

        public virtual Positions Positions { get; set; } = null!;
    }
}
