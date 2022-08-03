using CookieReader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieReader.Providers.Repositories
{
    public interface IUserRepository
    {
        CookieUserItem Register(RegisterVm model);
        CookieUserItem Validate(LoginVm model);
    }
}
