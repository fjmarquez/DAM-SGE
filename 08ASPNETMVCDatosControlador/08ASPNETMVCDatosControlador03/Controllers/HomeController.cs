using _08ASPNETMVCDatosControlador03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _08ASPNETMVCDatosControlador03.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            DateTime d = DateTime.Now;

            clsPersona persona1 = new clsPersona(2, "Francisco José", "Márquez", d, "Villarrasa 1", "555555555");
            
            return View(persona1);
        }

        [HttpPost]
        public ActionResult Index(clsPersona persona) {
            if (!ModelState.IsValid)
            {
                return View(persona);
            }
            else
            {
                return View("Editar", persona);
            }
            
        }


    }
}