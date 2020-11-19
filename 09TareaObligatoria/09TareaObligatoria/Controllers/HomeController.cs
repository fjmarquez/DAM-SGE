﻿using _09TareaObligatoria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _09TareaObligatoria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DateTime d = new DateTime().Date;

            clsPersona persona1 = new clsPersona(2, "Francisco José", "Márquez", d, "Villarrasa 1", "555555555");

            return View(persona1);
        }

        [HttpPost]
        public ActionResult Index(clsPersona persona)
        {
            return View("Editar", persona);
        }

    }
}