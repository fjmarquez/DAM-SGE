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

            return handler.getListadoPersonas();
        }

        // GET: api/Personas/5
        public clsPersona Get(int id)
        {
            listadoPersonasBL handler = new listadoPersonasBL();

            return handler.getPersonaPorID(id);
        }

        // POST: api/Personas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Personas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Personas/5
        public void Delete(int id)
        {
        }
    }
}
