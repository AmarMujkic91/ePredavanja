using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class JobAppliations
    {
        [Key]
        public int JobAppliationId { get; set; }

        public int JobId { get; set; }

        public int EventId { get; set; }

        public string Title { get; set; }

        public DateTime ApplicationDate { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public virtual Events Events { get; set; } = null!;

        public virtual Jobs Jobs { get; set; } = null!;
    }
}
