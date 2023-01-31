using Microsoft.AspNetCore.Mvc;
using System;

namespace MVCClinica.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Disposición de Médicos";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }


    }
}
