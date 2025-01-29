using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model.Requests
{
    public class EventsUpsertRequests
    {
        public string Title { get; set; } = null!;

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public int EventTypeId { get; set; }
    }
}
