using Examen2TrimestreBL.Handlers;
using Examen2TrimestreBL.Listados;
using Examen2TrimestreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Examen2TrimestreAPI.Controllers
{
    public class MisionesController : ApiController
    {
        // GET: api/Misiones
        public IEnumerable<Mision> Get()
        {
            clsListadoMisionesBL handler = new clsListadoMisionesBL();
            IEnumerable<Mision> lista = new Mision[] { };

            try
            {
                lista = handler.getListadoMisionesPorCompletar();
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


        // PUT: api/Misiones/5
        public int Put(Mision value)
        {

            clsHandlerMisionesBL handler = new clsHandlerMisionesBL();
            int state = 0;

            try
            {
                state = handler.actualizarMision(value);
                return state;
            }
            catch
            {
                throw new HttpResponseException(HttpStatusCode.ServiceUnavailable);
            }

            if (state == 0)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.Created);
            }

        }

    }
}
