using Microsoft.AspNetCore.Mvc;
using Practica01.Clases;
namespace Practica01.Controllers
{
    public class ClientesController : Controller
    {
        public string datosC(HClasesCLS cliente)
        {

            return cliente.nombre+" "+cliente.telefono+" "+cliente.domicilio;
        }
        public HClasesCLS datosCO()
        {
            HClasesCLS dat = new HClasesCLS();
            dat.nombre = "Brian";
            dat.telefono = "3531482591";
            dat.domicilio = "Calzada Revolucion";
            dat.horacompra = "10:00 a.m";
            return dat;
        }
        public List<HClasesCLS>datosCL()
        {
            List<HClasesCLS> listaDatosC = new List<HClasesCLS> ();
            HClasesCLS clase1=new HClasesCLS();
            clase1.nombre = "Hector";
            clase1.telefono = "353456789";
            clase1.domicilio = "lejos de aqui";
            clase1.horacompra = "11:00 a.m";
            listaDatosC.Add(clase1);

            HClasesCLS clase2 = new HClasesCLS();
            clase2.nombre = "Pepe";
            clase2.telefono = "353443789";
            clase2.domicilio = "cerca de aqui";
            clase2.horacompra = "11:30 a.m";
            listaDatosC.Add(clase2);

            HClasesCLS clase3 = new HClasesCLS();
            clase3.nombre = "Juan";
            clase3.telefono = "35323189";
            clase3.domicilio = "lejos de aqui";
            clase3.horacompra = "12:30 a.m";
            listaDatosC.Add(clase3);
            return listaDatosC;
        }
        public IActionResult Inicio()
        {
            return View();
        }
        public IActionResult ClienteDatos()
        {
            return View();
        }
    }
}
