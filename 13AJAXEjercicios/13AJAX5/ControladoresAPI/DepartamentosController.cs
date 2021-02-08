using _10CRUDPersonasBL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _10CRUDPersonasAPI.Controllers
{
    public class DepartamentosController : ApiController
    {

        public IEnumerable<clsDepartamento> Get()
        {
            listadoDepartamentosBL handler = new listadoDepartamentosBL();
            IEnumerable<clsDepartamento> lista = new clsDepartamento[] { };

            try
            {
                lista = handler.getListadoDepartamentos();
                return lista;
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if (lista.Count() > 0)
            {

                throw new HttpResponseException(HttpStatusCode.OK);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

        }

        public clsDepartamento Get(int id)
        {
            listadoDepartamentosBL handler = new listadoDepartamentosBL();
            clsDepartamento d = new clsDepartamento();

            try
            {
                d = handler.getDepartamentoPorID(id);
                return d;
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if (d != null || d.Id != 0)
            {

                throw new HttpResponseException(HttpStatusCode.OK);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }


        }


    }
}
