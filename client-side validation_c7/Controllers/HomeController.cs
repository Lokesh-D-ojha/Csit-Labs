using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using client_side_validation_c7.Models;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            // Process form submission (server-side validation)
            // Redirect or return appropriate response

            if (ModelState.IsValid)
            {
                // If model state is valid, proceed with processing
                // For example, save the student data to the database
                return RedirectToAction("Index", "Home");
            }

            // If model state is invalid, return to the same view with validation errors
            return View(student);
        }

        public IActionResult Index()
        {
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
