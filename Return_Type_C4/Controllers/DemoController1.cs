using Microsoft.AspNetCore.Mvc;

namespace Return_Type_C4.Controllers
{
    public class DemoController : Controller
    {
        // Return a view
        public IActionResult Index()
        {
            return View();
        }

        // Return JSON data
        public IActionResult JsonData()
        {
            var data = new { Name = "Lokesh Datta Ojha", Age = 30 };
            return Json(data);
        }

        // Return plain text content
        public IActionResult PlainText()
        {
            return Content("This is plain text content.");
        }

        // Return a file (assuming you have a file named sample.txt in wwwroot/files)
        public IActionResult FileDownload()
        {
            var filePath = "wwwroot/files/sample.txt";
            var contentType = "text/plain";
            var fileName = "sample.txt";
            return PhysicalFile(filePath, contentType, fileName);
        }

        // Return a redirect to another action
        public IActionResult RedirectToAction()
        {
            return RedirectToAction("Index", "Home");
        }

        // Return a redirect to an external URL
        public IActionResult RedirectToUrl()
        {
            return Redirect("https://www.Google.com");
        }

        // Return a status code
        public IActionResult NotFoundStatus()
        {
            return NotFound();
        }

        // Return no content
        public IActionResult NoContentResult()
        {
            return NoContent();
        }
    }
}
