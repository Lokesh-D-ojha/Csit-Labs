using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SessionState_C6.Models;
using System.Diagnostics;

namespace SessionState_C6.Controllers
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
            // Set session values
            HttpContext.Session.SetString("UserName", "Lokesh Datta Ojha");
            HttpContext.Session.SetInt32("UserAge", 22);

            return View();
        }

        public IActionResult About()
        {
            // Retrieve session values
            var userName = HttpContext.Session.GetString("UserName");
            var userAge = HttpContext.Session.GetInt32("UserAge");

            ViewBag.UserName = userName;
            ViewBag.UserAge = userAge;

            return View();
        }

        public IActionResult ClearSession()
        {
            // Clear session values
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
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
