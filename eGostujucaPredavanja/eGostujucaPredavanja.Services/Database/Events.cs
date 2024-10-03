using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string StartTime { get; set; }
        
        public string EndTime { get; set; }

        public byte[]? Slika { get; set; }

        public virtual ICollection<Sessions> Sessions { get; } = new List<Sessions>(); // Jedan event moze imat vise predavanja

        public virtual ICollection<UserEvents> UserEvents { get; } = new List<UserEvents>();

        public virtual ICollection<EventSponsors> EventSponsors { get; } = new List<EventSponsors>();

        public virtual ICollection<JobAppliations> JobAppliations { get; } = new List<JobAppliations>();

        public virtual ICollection<News> News { get; } = new List<News>();

        public virtual EventTypes EventType { get; set; } = null!;
    }
}
