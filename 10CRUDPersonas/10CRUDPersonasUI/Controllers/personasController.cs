using _10CRUDPersonasBL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10CRUDPersonasUI.Controllers
{
    public class personasController : Controller
    {
        // GET: personas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listado()
        {
            listadoPersonasBL listBL = new listadoPersonasBL();

            List<clsPersona> list = listBL.getListadoPersonas();

            return View("listado", list);
        }
    }
}