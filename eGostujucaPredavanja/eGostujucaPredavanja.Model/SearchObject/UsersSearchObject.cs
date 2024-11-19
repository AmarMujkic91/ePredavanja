using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model.SearchObject
{
    public class UsersSearchObject : BaseSearchObject
    {
        public string? FirstNameGTE { get; set; }

        public string? LastNameGTE { get; set; }

        public string? UserName { get; set; }

        public string? Email { get; set; }

        public bool? IsUserPositionIncluded { get; set; }

        public string? OrderBy { get; set; }
    }
}
