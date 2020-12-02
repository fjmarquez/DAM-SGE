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
            List<clsPersona> list;

            try
            {
                list = new listadoPersonasDAL().getListadoPersonas();
            }catch(Exception e)
            {
                throw e;
            }
            
            return list;
        }

        public clsPersona getPersonaPorID(int ID)
        {
            clsPersona persona;

            try
            {
                persona = new listadoPersonasDAL().getPersonaPorID(ID);
            }
            catch(Exception e)
            {
                throw e;
            }

            return persona;
        }

    }
}
