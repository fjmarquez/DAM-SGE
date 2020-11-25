using _10CRUDPersonasBL.Handlers;
using _10CRUDPersonasBL.Listados;
using _10CRUDPersonasEntities;
using _10CRUDPersonasUI.Models;
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

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new List<clsPersonaConNombreDepartamento>();

            foreach (clsPersona p in list)
            {
                clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento();

                pConNombreDepartamento.Id = p.Id;
                pConNombreDepartamento.Nombre = p.Nombre;
                pConNombreDepartamento.Apellidos = p.Apellidos;
                pConNombreDepartamento.Direccion = p.Direccion;
                pConNombreDepartamento.Telefono = p.Telefono;
                pConNombreDepartamento.Foto = p.Foto;
                pConNombreDepartamento.IdDepartamento = p.IdDepartamento;
                clsDepartamento departamento = new listadoDepartamentosBL().getDepartamentoPorID(p.IdDepartamento);
                pConNombreDepartamento.NombreDepartamento = departamento.Departamento;

                listConNombreDepartamento.Add(pConNombreDepartamento);


            }

                return View("listado", listConNombreDepartamento);
        }


        public ActionResult Delete(int id)
        {

            clsPersona persona = new listadoPersonasBL().getPersonaPorID(id);

            return View("delete", persona);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            int fieldCount = new clsHandlerPersonaBL().deletePersonaBL(id);

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new List<clsPersonaConNombreDepartamento>();

            foreach (clsPersona p in list)
            {
                clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento();

                pConNombreDepartamento.Id = p.Id;
                pConNombreDepartamento.Nombre = p.Nombre;
                pConNombreDepartamento.Apellidos = p.Apellidos;
                pConNombreDepartamento.Direccion = p.Direccion;
                pConNombreDepartamento.Telefono = p.Telefono;
                pConNombreDepartamento.Foto = p.Foto;
                pConNombreDepartamento.IdDepartamento = p.IdDepartamento;
                clsDepartamento departamento = new listadoDepartamentosBL().getDepartamentoPorID(p.IdDepartamento);
                pConNombreDepartamento.NombreDepartamento = departamento.Departamento;

                listConNombreDepartamento.Add(pConNombreDepartamento);


            }
            return View("listado", listConNombreDepartamento);
        }
    }
}