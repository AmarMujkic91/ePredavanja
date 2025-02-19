using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    
    public partial class News
    {
        [Key]
        public int NewsId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual Events Events { get; set; } = null!;

        public byte[]? Slika { get; set; }

    }
}
