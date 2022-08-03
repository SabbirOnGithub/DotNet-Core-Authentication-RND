using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieReader.Models
{
    public class CookieUserItem
    {
        public Guid UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;
    }
}
