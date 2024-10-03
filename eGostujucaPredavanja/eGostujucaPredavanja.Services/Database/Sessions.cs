using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class Sessions
    {
        [Key]
        public int SessionId { get; set; }

        public int EventId { get; set; }

        public string SessionTitle { get; set; }

        public string SessionDescription { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public DateTime SessionDate { get; set; }

        public string Building { get; set; }

        public string Room { get; set; }

        public virtual ICollection<UserSessions> UserSessions { get; } = new List<UserSessions>();

        public virtual ICollection<SessionSpeakers> SessionSpeakers { get; } = new List<SessionSpeakers>();

        public byte[]? Slika { get; set; }
    }
}
