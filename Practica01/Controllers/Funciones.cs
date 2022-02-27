using Microsoft.AspNetCore.Mvc;

namespace Practica01.Controllers
{
    public class Funciones : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public double DescuentoVta(double preciov,double descuentov)
        {
            return preciov - ((preciov / 100) * descuentov);
        }
        public double DescuentoCom(double precioc, double descuentoc)
        {
            return precioc - ((precioc / 100) * descuentoc);
        }
        public double CalcIVA(double precio)
        {
            return precio * .16;
        }
        public String ModificarInv(String var)
        {
            return var + " es Puto.";
        }
        
    }
}
