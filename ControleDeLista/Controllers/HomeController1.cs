using Microsoft.AspNetCore.Mvc;

namespace ControleDeLista.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
