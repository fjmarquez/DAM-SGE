using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08ASPNETMVCDatosControlador01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saludo(String nombre, String apellidos)
        {
            ViewBag.saludo = "Hola " + nombre + " " + apellidos;
            return View();
        }
    }
}