using Custom_auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_auth.Services
{
    public class AccountService : IAccountService
    {
        private List<Account> accounts;

        public AccountService()
        {
            accounts = new List<Account>
            {
                new Account
                {
                    UserName = "rahim",
                    Password = "123",
                    Roles = new List<string> { "SuperAdmin", "Admin", "Employee" }
                },
                new Account
                {
                    UserName = "karim",
                    Password = "456",
                    Roles = new List<string> {"Admin", "Employee" }
                },
                new Account
                {
                    UserName = "kamal",
                    Password = "789",
                    Roles = new List<string> {"Employee" }
                }
            };
        }

        public Account Find(string username)
        {
            return accounts.FirstOrDefault(x => x.UserName == username);
        }

        public bool Login(string username, string password)
        {
           return accounts.Where(x =>x.UserName == username && x.Password == password).Any();
        }
    }
}
