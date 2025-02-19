using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model.Requests
{
    public class AdminUsersUpdateRequests
    {
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string? Email { get; set; }

        public string? Addres { get; set; }

        public string? Phone { get; set; }

        public string UserName { get; set; } = null!;

        public virtual ICollection<UserPositions> UserPositions { get; } = new List<UserPositions>();
    }
}
