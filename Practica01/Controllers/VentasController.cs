using Microsoft.AspNetCore.Mvc;

namespace Practica01.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
