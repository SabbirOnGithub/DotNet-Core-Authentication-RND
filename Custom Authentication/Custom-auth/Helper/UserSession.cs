using Custom_auth.Models;
using Microsoft.AspNetCore.Http;

namespace Custom_auth.Helper
{
    public static class UserSession
    {
        public static string GetUsernameFromSession(this ISession _session)
        {
            if (_session.GetString("username") != null)
            {
                var info = _session.GetString("username");
                return info;
            }
            else
            {
                return null;
            }
        }
    }
}
