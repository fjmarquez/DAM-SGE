using ExamenSGE_DAL.ListadosDAL;
using ExamenSGE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSGE_BL.ListadosBL
{
    public class clsListadoMisionesBL
    {

        public List<clsMision> getListadoMisionesPorCompletar()
        {
            List<clsMision> list;

            try
            {
                list = new clsListadoMisionesDAL().getListadoMisionesPorCompletar();
            }catch(SqlException e)
            {
                throw e;
            }

            return list;

        }

        public clsMision getMision(int id)
        {

            clsMision mision;

            try
            {
                mision = new clsListadoMisionesDAL().getMision(id);
            }catch(SqlException e)
            {
                throw e;
            }

            return mision;

        }

    }
}
