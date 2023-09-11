
using Microsoft.AspNetCore.Mvc;

namespace Resume.Presentation.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string email, string username)
        {
            return View();
        }
        [HttpPost]
        public IActionResult lisofusers(string email, string username)
        {
            return View();
        }

    }
}
