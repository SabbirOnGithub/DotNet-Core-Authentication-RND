using Custom_auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_auth.Services
{
    public interface IAccountService
    {
        public bool Login(string username, string password);
        public Account Find(string username); 
    }
}
