using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGostujucaPredavanja.Model.Requests
{
    public class UsersInsertRequests
    {
        public string Firstname { get; set; } = null!;

        public string Lastname { get; set; } = null!;

        public string? Email { get; set; }

        public string? Addres { get; set; }

        public string? Phone { get; set; }

        public string UserName { get; set; } = null!;

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
