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
            return new listadoPersonasBL().getListadoPersonas();
        }

        // GET: api/Personas/5
        public string Get(int id)
        {
            return "value";
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
