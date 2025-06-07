using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class WebsiteController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }
    }
}
