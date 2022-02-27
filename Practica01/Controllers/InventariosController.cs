using Microsoft.AspNetCore.Mvc;

namespace Practica01.Controllers
{
    public class InventariosController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
