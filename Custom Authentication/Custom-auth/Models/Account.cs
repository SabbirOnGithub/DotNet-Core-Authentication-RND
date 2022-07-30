using System.Collections.Generic;

namespace Custom_auth.Models
{
    public class Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<string> Roles { get; set; }
    }
}
