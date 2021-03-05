using Examen2TrimestreDAL.Handlers;
using Examen2TrimestreEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2TrimestreBL.Handlers
{
    public class clsHandlerMisionesBL
    {

        public int actualizarMision(Mision mision)
        {

            int fieldCount = 0;

            try
            {
                fieldCount = new clsHandlerMisiones().actualizarMision(mision);
            }
            catch (Exception e)
            {
                throw e;
            }


            return fieldCount;

        }

    }
}
