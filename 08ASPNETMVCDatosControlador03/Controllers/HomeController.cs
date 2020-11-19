﻿using _08ASPNETMVCDatosControlador03.Models;
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
            DateTime d = new DateTime().Date;

            clsPersona persona1 = new clsPersona(2, "Francisco José", "Márquez", d, "Villarrasa 1", "555555555", new clsDepartamento(1, "Marketin"));

            return View(persona1);
        }

        [HttpPost]
        public ActionResult Index(clsPersona persona)
        {
            return View("Editar", persona);
        }


    }
}