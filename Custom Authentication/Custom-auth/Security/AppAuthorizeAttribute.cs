using Custom_auth.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_auth.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AppAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        public string Roles { get; set; }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            Account account = (Account)context.HttpContext.Items["account"];

            if (account != null)
            {
                string[] roles = Roles.Split(new char[] { ',' });

                if (!roles.Any(r => account.Roles.Contains(r)))
                {
                    context.HttpContext.Response.Redirect("/login/accessDenied");
                }
            }

        }
    }
}
