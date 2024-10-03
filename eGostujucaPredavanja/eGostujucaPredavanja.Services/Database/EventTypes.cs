using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class EventTypes
    {
        [Key]
        public int EventTypeId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Events> Events { get; } = new List<Events>();
    }
}
