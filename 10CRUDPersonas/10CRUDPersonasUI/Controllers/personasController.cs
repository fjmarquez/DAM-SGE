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


        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Devuelve un listado de personas con nombre de departamento, que se listaran mediante scaffolding en la vista "listado"
        /// </summary>
        /// <returns></returns>
        public ActionResult listado()
        {

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);
 

                return View("listado", listConNombreDepartamento);
        }

        /// <summary>
        /// Muestra la vista delete con la informacion de la persona que deseamos eliminar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {

            clsPersona pDelete = new listadoPersonasBL().getPersonaPorID(id);

            return View("delete", pDelete);
        }


        /// <summary>
        /// Es la accion que se realizara cuando pulsemos sobre el input "delete" en la vista "delete", eliminara la persona indicada
        /// y mostrara la vista "listado" con la lista de personas actualizada tras borrar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Delete")]
        public ActionResult DeletePost(int id)
        {
            int fieldCount = new clsHandlerPersonaBL().deletePersonaBL(id);

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);

            return View("listado", listConNombreDepartamento);
        }

        /// <summary>
        /// Muestra la vista edit con la informacion de la persona a editar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit (int id)
        {

            clsPersona pEdit = new listadoPersonasBL().getPersonaPorID(id);
            List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

            clsPersonaConListadoDepartamentos pListDepartamentos = new clsPersonaConListadoDepartamentos(pEdit, listDepartamentos);

            return View("edit", pListDepartamentos);
        }

        /// <summary>
        /// Esta accion se realizara cuando hagamos click sobre el input de la vista edit, creara un nuevo objeto persona con la informacion editada y
        /// realizara la modificacion en la base de datos a traves de la capa BL. Tras editar mostrara el listado de personas actual.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fechanacimiento"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="iddepartamento"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Edit")]
        public ActionResult EditPost(int id, string nombre, string apellidos, DateTime fechanacimiento, string direccion, string telefono, int iddepartamento)
        {

            clsPersona pEdit = new clsPersona(id, nombre, apellidos, fechanacimiento, direccion, telefono, iddepartamento);

            int fieldCount = new clsHandlerPersonaBL().updatePersonaBL(pEdit);

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);


            return View("listado", listConNombreDepartamento);
        }


        public ActionResult Create()
        {
            clsPersona pCreate = new clsPersona();
            List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

            clsPersonaConListadoDepartamentos pListDepartamentos = new clsPersonaConListadoDepartamentos(pCreate, listDepartamentos);

            return View("create", pListDepartamentos);
        }


        [HttpPost, ActionName("Create")]
        public ActionResult CreatePost(string nombre, string apellidos, DateTime fechanacimiento, string direccion, string telefono, int iddepartamento)
        {

            clsPersona pCreate = new clsPersona(0, nombre, apellidos, fechanacimiento, direccion, telefono, iddepartamento);

            int fieldCount = new clsHandlerPersonaBL().createPersonaBL(pCreate);

            List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);

            return View("listado", listConNombreDepartamento);
        }


        public ActionResult Details(int id)
        {
            clsPersona pDetails = new listadoPersonasBL().getPersonaPorID(id);

            clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento().getPersonaConNombreDepartamento(pDetails);

            return View("details", pConNombreDepartamento);
        }

    }
}