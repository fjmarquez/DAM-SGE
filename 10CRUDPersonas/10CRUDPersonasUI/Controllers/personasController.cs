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
            try
            {
                List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

                List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);
                
                return View("listado", listConNombreDepartamento);
            }
            catch(Exception e)
            {
                return View("error");
                throw e;
            }
                
        }

        /// <summary>
        /// Muestra la vista delete con la informacion de la persona que deseamos eliminar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            try
            {
                clsPersona pDelete = new listadoPersonasBL().getPersonaPorID(id);

                if(pDelete.Id != 0)
                {
                    return View("delete", pDelete);
                }
                else
                {
                    return View("error");
                }
                
            }
            catch(Exception e)
            {
                return View("error");
                throw e;
            }
            
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

            try
            {
                int fieldCount = new clsHandlerPersonaBL().deletePersonaBL(id);

                List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

                List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);

                if(fieldCount == 1)
                {
                    return View("listado", listConNombreDepartamento);
                }else
                {
                    return View("error");
                }
                
            }
            catch(Exception e)
            {
                return View("error");
                throw e;
            }
            
        }

        /// <summary>
        /// Muestra la vista edit con la informacion de la persona a editar
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit (int id)
        {
            try
            {
                clsPersona pEdit = new listadoPersonasBL().getPersonaPorID(id);
                List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

                clsPersonaConListadoDepartamentos pListDepartamentos = new clsPersonaConListadoDepartamentos(pEdit, listDepartamentos);

                if(pEdit.Id != 0)
                {
                    return View("edit", pListDepartamentos);
                }
                else
                {
                    return View("error");
                }

            }
            catch(Exception e)
            {
                return View("error");
            }

            
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
        public ActionResult EditPost(clsPersonaConListadoDepartamentos pListDepartamentos)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

                    pListDepartamentos.ListDepartamentos = listDepartamentos;

                    return View(pListDepartamentos);
                }
                else
                {
                    clsPersona pCreate = new clsPersona();

                    pCreate.Id = pListDepartamentos.Id;
                    pCreate.Nombre = pListDepartamentos.Nombre;
                    pCreate.Apellidos = pListDepartamentos.Apellidos;
                    pCreate.Direccion = pListDepartamentos.Direccion;
                    pCreate.Telefono = pListDepartamentos.Telefono;
                    pCreate.IdDepartamento = pListDepartamentos.IdDepartamento;
                    pCreate.FechaNacimiento = pListDepartamentos.FechaNacimiento;

                    int fieldCount = new clsHandlerPersonaBL().updatePersonaBL(pCreate);

                    List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

                    List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);

                    if (fieldCount == 1)
                    {
                        return View("listado", listConNombreDepartamento);
                    }
                    else
                    {
                        return View("error");
                    }
                }
            }
            catch
            {
                return View("error");
            }
        }

        /// <summary>
        /// Esta accion se realizara cuando el usuario desee crear un nuevo usuario, se mostrara una vista con un formulario vacio,
        /// el cual tiene un submit que si los campos son rellenados correctamente creara una nueva persona y la insertara en la BD
        /// mediante la capa BL
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            try
            {
                clsPersona pCreate = new clsPersona();
                List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

                clsPersonaConListadoDepartamentos pListDepartamentos = new clsPersonaConListadoDepartamentos(pCreate, listDepartamentos);

                return View("create", pListDepartamentos);
            }
            catch(Exception e)
            {
                return View("error");
            }
            
        }

        /// <summary>
        /// Esta accion comprueba que los campos hayan sido rellenado conforme a las dataAnnotations y si todo es correcto 
        /// creara un objeto persona y lo persistira en la BD mediante la capa BL.
        /// </summary>
        /// <param name="pListDepartamentos"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Create")]
        public ActionResult CreatePost(clsPersonaConListadoDepartamentos pListDepartamentos)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    List<clsDepartamento> listDepartamentos = new listadoDepartamentosBL().getListadoDepartamentos();

                    pListDepartamentos.ListDepartamentos = listDepartamentos;

                    return View(pListDepartamentos);
                }
                else
                {
                    clsPersona pCreate = new clsPersona();

                    pCreate.Nombre = pListDepartamentos.Nombre;
                    pCreate.Apellidos = pListDepartamentos.Apellidos;
                    pCreate.Direccion = pListDepartamentos.Direccion;
                    pCreate.Telefono = pListDepartamentos.Telefono;
                    pCreate.IdDepartamento = pListDepartamentos.IdDepartamento;
                    pCreate.FechaNacimiento = pListDepartamentos.FechaNacimiento;

                    int fieldCount = new clsHandlerPersonaBL().createPersonaBL(pCreate);

                    List<clsPersona> list = new listadoPersonasBL().getListadoPersonas();

                    List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new clsListadoPersonasConNombreDepartamento().getListadoPersonasConNombreDepartamento(list);

                    if (fieldCount == 1)
                    {
                        return View("listado", listConNombreDepartamento);
                    }
                    else
                    {
                        return View("error");
                    }
                }
            }catch(Exception e)
            {
                return View("error");
            }
  
        }

        /// <summary>
        /// Esta accion mostrara una vista con toda la informacion referente a la persona cuyo id hemos recibido.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            try
            {
                clsPersona pDetails = new listadoPersonasBL().getPersonaPorID(id);

                clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento().getPersonaConNombreDepartamento(pDetails);

                if(pConNombreDepartamento.Id != 0)
                {
                    return View("details", pConNombreDepartamento);
                }else
                {
                    return View("error");
                }
                
            }
            catch(Exception e)
            {
                return View("error");
            }
            
        }

    }
}