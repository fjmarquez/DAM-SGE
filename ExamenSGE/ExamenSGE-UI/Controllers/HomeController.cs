﻿using ExamenSGE_BL.HandlersBL;
using ExamenSGE_BL.ListadosBL;
using ExamenSGE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenSGE_UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /// <summary>
        /// Devuelve una vista con un dropwown con todas las misiones por completar
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<clsMision> list;

            try
            {
                list = new clsListadoMisionesBL().getListadoMisionesPorCompletar();
            }
            catch(SqlException e)
            {
                throw e;
            }

            

            return View("index", list);
        }

        /// <summary>
        /// Devuelve una vista con toda la informacion de la mision selecionada, donde solamente podemos editar los creditos
        /// </summary>
        /// <param name="mision"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost(int mision)
        {
            clsMision misionSeleccionada;

            try
            {
                misionSeleccionada = new clsListadoMisionesBL().getMision(mision);
            }
            catch (SqlException e)
            {
                throw e;
            }

            return View("editar", misionSeleccionada);
        }

        /// <summary>
        /// Accion que realizara el formulario de la vista editar, y recibira una mision para actualizarla mediante la capa bl
        /// </summary>
        /// <param name="mision"></param>
        /// <returns></returns>
        public ActionResult updateMision(clsMision mision)
        {
            try
            {

            }catch(SqlException e)
            {
                throw e;
            }
            int fieldCount = new clsHandlerMisionBL().updatePrecioMision(mision);

            return View("Index");
        }

    }
}