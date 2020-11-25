using _10CRUDPersonasDAL.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasDAL.Handlers
{
    public class clsHandlerPersonaDAL
    {

        public int deletePersonaDAL (int ID)
        {
            clsMyConnectionDAL con = new clsMyConnectionDAL();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;

            try
            {
                SqlConnection sqlc = con.getConnection();
                query.CommandText = "DELETE FROM Personas WHERE ID=" + ID;
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                
                reader.Close();
                con.closeConnection(ref sqlc);
            }
            catch (SqlException e)
            {
                throw e;
            }


            return reader.RecordsAffected;
        }

    }
}
