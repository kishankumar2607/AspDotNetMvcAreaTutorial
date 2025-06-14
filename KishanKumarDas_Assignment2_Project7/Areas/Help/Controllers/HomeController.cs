using Microsoft.AspNetCore.Mvc;

namespace KishanKumarDas_Assignment2_Project7.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Home";
            return View();
        }
    }
}
