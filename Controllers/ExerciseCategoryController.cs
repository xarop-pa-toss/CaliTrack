using Microsoft.AspNetCore.Mvc;

namespace CaliTrack.Controllers;

public class ExerciseCategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
