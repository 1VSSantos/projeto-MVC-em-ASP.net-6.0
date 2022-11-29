using Microsoft.AspNetCore.Mvc;

namespace ControleDeLista.Controllers
{
    public class ListaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
