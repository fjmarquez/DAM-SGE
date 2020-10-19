using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _06HolaMundoASPNETMVC_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        /*
        public String Index()
        {
            return "<h1>Hola mundo desde el controlador</h1>";
        }
        */
        public ActionResult Index()
        {
            return View();
            String var = "Prueba var";
        }

        public String francisco()
        {
            return "<h1>Hola Francisco mundo desde el controlador</h1>";
        }
    }
}