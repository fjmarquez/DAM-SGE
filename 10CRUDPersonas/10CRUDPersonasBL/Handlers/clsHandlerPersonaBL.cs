using _10CRUDPersonasDAL.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasBL.Handlers
{
    public class clsHandlerPersonaBL
    {

        public int deletePersonaBL(int id)
        {
            int fieldCount = new clsHandlerPersonaDAL().deletePersonaDAL(id);

            return fieldCount;
        }

    }
}
