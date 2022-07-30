using Microsoft.AspNetCore.Mvc;

namespace Custom_auth.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("admin")]
        [Route("admin/product")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
