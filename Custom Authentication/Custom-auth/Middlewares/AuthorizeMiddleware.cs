using Custom_auth.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Custom_auth.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class AuthorizeMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthorizeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, IAccountService accountService)
        {
            httpContext.Items["account"] = accountService.Find(httpContext.Session.GetString("username"));

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthorizeMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthorizeMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthorizeMiddleware>();
        }
    }
}
