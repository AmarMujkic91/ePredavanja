using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public partial class Speakers 
    {
        [Key]
        public int SpeakerId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Organisation { get; set; }

        public string JobTitle { get; set; }

        public string Bio { get; set; }

        public byte[]? Slika { get; set; }

        public virtual ICollection<SessionSpeakers> SessionSpeakers { get; } = new List<SessionSpeakers>();
    }
}
