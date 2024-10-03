using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Services.Database
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string? Email { get; set; } 

        public string? Addres { get; set; }

        public string? Phone { get; set; }

        public string UserName { get; set; } = null!;

        public string LozinkaHash { get; set; } = null!;

        public string LozinkaSalt { get; set; } = null!;

        public byte[]? Slika { get; set; }

        public virtual ICollection<UserPositions> UserPositions { get; } = new List<UserPositions>();

        public virtual ICollection<UserSessions> UserSessions { get; } = new List<UserSessions>();

        public virtual ICollection<UserEvents> UserEvents { get; } = new List<UserEvents>();
    }
}
