using Microsoft.AspNetCore.Mvc;

namespace Practica01.Controllers
{
    public class AlmacenController : Controller
    {
        public IActionResult Inicio()
        {
            return View();
        }
    }
}
