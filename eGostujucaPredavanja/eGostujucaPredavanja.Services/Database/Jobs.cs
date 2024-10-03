using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class Jobs
    {
        [Key]
        public int JobId { get; set; }

        public int EventId { get; set; }

        public string Title { get; set; }

        public DateTime PublishDate { get; set; }

        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public virtual ICollection<JobAppliations> JobAppliations { get; } = new List<JobAppliations>();

        public byte[]? Slika { get; set; }
    }
}
