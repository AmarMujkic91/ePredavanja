using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class EventSponsors
    {
        [Key]
        public int EventSponsorId { get; set; }

        public int EventId { get; set; }

        public int SponzorId { get; set; }

        public string BootNumber { get; set; }

        public virtual Events Events { get; set; } = null!;

        public virtual Sponsors Sponsors { get; set; } = null!;
    }
}
