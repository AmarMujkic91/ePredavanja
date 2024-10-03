using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class UserPositions
    {
        [Key]
        public int UserPositionId { get; set; }

        public int UserId { get; set; }

        public int PositionId { get; set; }

        public DateTime DateOfChanges { get; set; }

        public virtual Users Users { get; set; } = null!;

        public virtual Positions Positions { get; set; } = null!;
    }
}
