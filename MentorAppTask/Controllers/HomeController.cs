using Microsoft.AspNetCore.Mvc;

namespace MentorAppTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
