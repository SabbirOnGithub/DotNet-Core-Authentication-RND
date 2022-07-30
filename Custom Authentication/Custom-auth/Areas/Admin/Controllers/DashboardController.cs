using Custom_auth.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Custom_auth.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        
        [Route("admin/dashboard")]
        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View();
        }

        [AppAuthorize(Roles = "SuperAdmin")]
        [Route("admin/dashboard/page1")]
        public IActionResult Page1()
        {
            return View();
        }

        [AppAuthorize(Roles = "SuperAdmin,Admin")]
        [Route("admin/dashboard/page2")]
        public IActionResult Page2()
        {
            return View();
        }

        [AppAuthorize(Roles = "SuperAdmin,Admin,Employee")]
        [Route("admin/dashboard/page3")]
        public IActionResult Page3()
        {
            return View();
        }
    }
}
