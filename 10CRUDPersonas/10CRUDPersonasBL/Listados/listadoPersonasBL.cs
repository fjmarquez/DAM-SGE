using _10CRUDPersonasDAL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasBL.Listados
{
    public class listadoPersonasBL
    {

        public List<clsPersona> getListadoPersonas()
        {
            List<clsPersona> list = new listadoPersonasDAL().getListadoPersonas();

            return list;
        }

    }
}
