using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "dani" && password == "Dani123")
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid username or password.";

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}