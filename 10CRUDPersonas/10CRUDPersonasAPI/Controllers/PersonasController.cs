using _10CRUDPersonasBL.Handlers;
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
    public class PersonasController : ApiController
    {
        // GET: api/Personas
        public IEnumerable<clsPersona> Get()
        {
            listadoPersonasBL handler = new listadoPersonasBL();
            IEnumerable<clsPersona> lista = new clsPersona[]{};

            try
            {
                lista = handler.getListadoPersonas();
                
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

            return lista;
        }

        // GET: api/Personas/5
        public clsPersona Get(int id)
        {
            listadoPersonasBL handler = new listadoPersonasBL();
            clsPersona p = new clsPersona();

            try
            {
                p = handler.getPersonaPorID(id);
                
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if(p.Id != 0)
            {
                throw new HttpResponseException(HttpStatusCode.OK);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            return p;
        }

        // POST: api/Personas
        public void Post(clsPersona value)
        {
            clsHandlerPersonaBL handler = new clsHandlerPersonaBL();
            int state = 0;

            try
            {
                state = handler.createPersonaBL(value);
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if(state == 0)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.OK);
            }

        }

        // PUT: api/Personas/5
        public void Put(clsPersona value)
        {
            clsHandlerPersonaBL handler = new clsHandlerPersonaBL();
            int state = 0;

            try
            {
                state = handler.updatePersonaBL(value);
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if(state == 0)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.Created);
            }
            
        }

        // DELETE: api/Personas/5
        public void Delete(int id)
        {
            clsHandlerPersonaBL handler = new clsHandlerPersonaBL();
            int state = 0;

            try
            {
                state = handler.deletePersonaBL(id);
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if(state == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.NoContent);
            }

            


        }
    }
}
