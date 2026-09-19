using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using portfolio_.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") != "true")
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        [ResponseCache(
            Duration = 0,
            Location = ResponseCacheLocation.None,
            NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id
                    ?? HttpContext.TraceIdentifier
            });
        }
    }
}