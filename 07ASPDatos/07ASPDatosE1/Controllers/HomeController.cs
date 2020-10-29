using _07ASPDatosE1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _07ASPDatosE1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string saludo;
            string fechaActual = DateTime.Now.ToString();

            clsPersona p = new clsPersona();
            p.IDPersona = 1;
            p.nombre = "Francisco";
            p.apellidos = "Marquez Pulido";
            p.direccion = "Huelva";
            p.telefono = "123456789";

            if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 20)
            {
                saludo = "Buenas tardes";
            }
            else if (DateTime.Now.Hour < 12 && DateTime.Now.Hour > 5)
            {
                saludo = "Buenos dias";
            }
            else
            {
                saludo = "Buenas noches";
            }

            ViewData["saludo"] = saludo;
            ViewBag.fecha = fechaActual;

            return View(p);
        }

        public ActionResult listadoPersonas()
        {
            List<clsPersona> listaPersonas = new List<clsPersona>();


            return View();
        }
    }
}