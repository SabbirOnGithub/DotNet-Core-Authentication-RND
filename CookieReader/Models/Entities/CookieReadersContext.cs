using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieReader.Models.Entities
{
    public class CookieReadersContext : DbContext
    {
        public CookieReadersContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CookieUser> Users { get; set; }
    }
}
