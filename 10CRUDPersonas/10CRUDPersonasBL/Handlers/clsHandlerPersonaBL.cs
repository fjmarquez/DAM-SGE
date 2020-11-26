using _10CRUDPersonasDAL.Handlers;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasBL.Handlers
{
    public class clsHandlerPersonaBL
    {
        /// <summary>
        /// Funcion de la capa BL, la cual usa la capa DAL para acceder a la BD Azure y eliminar la persona cuyo id se corresponde
        /// con el id recibido por parametros
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int deletePersonaBL(int id)
        {
            int fieldCount = new clsHandlerPersonaDAL().deletePersonaDAL(id);

            return fieldCount;
        }

        /// <summary>
        /// Funcion de la capa BL, la cual usa la capa DAL para acceder a la BD Azure y actualiza los registros de la persona 
        /// recibida por parametros
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int updatePersonaBL(clsPersona persona)
        {
            int fieldCount = new clsHandlerPersonaDAL().updatePersonaDAL(persona);

            return fieldCount;
        }

    }
}
