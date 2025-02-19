using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public partial class Sponsors
    {
        [Key]
        public int SponsorId { get; set; }

        public string PrimaryContactName { get; set; }

        public string OrganisationName { get; set; }

        public string OrganisationEmail { get; set; }

        public string Website { get; set; }

        public byte[]? Slika { get; set; }

        public string Description { get; set; }

        public virtual ICollection<EventSponsors> EventSponsors { get; } = new List<EventSponsors>();
    }
}
