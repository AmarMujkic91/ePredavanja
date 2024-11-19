using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model
{
    public partial class Users
    {
        public int UserId { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string? Email { get; set; }

        public string? Addres { get; set; }

        public string? Phone { get; set; }

        public string UserName { get; set; } = null!;

        public byte[]? Slika { get; set; }

        public virtual ICollection<UserPositions> UserPositions { get; } = new List<UserPositions>();
    }
}
