using Microsoft.AspNetCore.Mvc;

namespace CaliTrack.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
