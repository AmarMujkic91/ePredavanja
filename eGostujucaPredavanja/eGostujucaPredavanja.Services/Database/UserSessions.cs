using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class UserSessions
    {
        [Key]
        public int UserSessionId { get; set; }

        public int EventId { get; set; } // Kojem eventu pripada

        public int SessionId { get; set; } // O kojojem se predavanju radi

        public int UserId { get; set; } // O kojem se studentu radi

        public virtual Users User { get; set; } = null!;

        public virtual Sessions Session { get; set; } = null!;


        /// <summary>
        /// UserEventID
        /// </summary>
    }
}
