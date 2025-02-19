using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public partial class SessionSpeakers
    {
        [Key]
        public int SessionSpeakerId { get; set; }

        public int SessionId { get; set; }

        public int SpeakerId { get; set; }

        public virtual Sessions Session { get; set; } = null!;

        public virtual Speakers Speaker { get; set; } = null!;
    }
}
