using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class SessionSpeakers
    {
        [Key]
        public int SessionSpeakerId { get; set; }

        public int SessionId { get; set; }

        public int SpeakerId { get; set; }

        public virtual Sessions Sessions { get; set; } = null!;

        public virtual Speakers Speakers { get; set; } = null!;
    }
}
