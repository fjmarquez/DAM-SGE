using ExamenSGE_DAL.HandlersDAL;
using ExamenSGE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSGE_BL.HandlersBL
{
    public class clsHandlerMisionBL
    {
        /// <summary>
        /// Funcion que accede a la base de datos a traves de la capa DAL y modfica una mision
        /// </summary>
        /// <param name="mision"></param>
        /// <returns></returns>
        public int updatePrecioMision(clsMision mision)
        {
            int fieldCount;

            try
            {
                fieldCount = new clsHandlerMisionDAL().updatePrecioMision(mision);
            }catch(SqlException e)
            {
                throw e;
            }

            return fieldCount;
        }

    }

}
