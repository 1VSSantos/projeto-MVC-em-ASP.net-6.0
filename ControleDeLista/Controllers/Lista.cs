using Microsoft.AspNetCore.Mvc;

namespace ControleDeLista.Controllers
{
    public class Lista : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
