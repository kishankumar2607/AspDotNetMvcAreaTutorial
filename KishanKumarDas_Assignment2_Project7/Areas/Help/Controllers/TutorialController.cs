using Microsoft.AspNetCore.Mvc;

namespace KishanKumarDas_Assignment2_Project7.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id)) Id = "Page1";

            ViewBag.ActiveTab = "Tutorial";

            return View(Id);
        }
    }
}
