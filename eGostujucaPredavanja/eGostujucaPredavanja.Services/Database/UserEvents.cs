using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public partial class UserEvents
    {
        [Key]
        public int UserEventId { get; set; }

        public int EventId { get; set; }

        public int UserId { get; set; }

        public byte CheckedIn { get; set; }

        public virtual Events Event { get; set; } = null!;

        public virtual Users User { get; set; } = null!;
    }
}
