using Custom_auth.Models;
using Custom_auth.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Custom_auth.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IAccountService _accountService;

        public LoginController(ILogger<LoginController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string userName, string password)
        {
            if (_accountService.Login(userName, password))
            {
                HttpContext.Session.SetString("username", userName);
                return RedirectToAction("Index", "Dashboard", new {area = "admin"});
            }
            else
            {
                ViewBag.message = "Invalid User";
                return View("Index");
            }
           
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("index");
        }

        public IActionResult Welcome()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
