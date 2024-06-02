using DI_LAb_c4.Models;
using DI_LAb_c4.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DI_LAb_c4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHelloService _helloService;

        public HomeController(ILogger<HomeController> logger, IHelloService helloService)
        {
            _logger = logger;
            _helloService = helloService;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _helloService.SayHello();
            return View();
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
