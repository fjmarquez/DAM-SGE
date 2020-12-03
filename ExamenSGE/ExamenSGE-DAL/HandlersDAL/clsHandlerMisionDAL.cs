using ExamenSGE_DAL.ConnectionDAL;
using ExamenSGE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSGE_DAL.HandlersDAL
{
    public class clsHandlerMisionDAL
    {
        /// <summary>
        /// Esta funcion acceddera directamente a la BD y actualizara los registros de una Mision
        /// </summary>
        /// <param name="mision"></param>
        /// <returns></returns>
        public int updatePrecioMision(clsMision mision)
        {

            clsConnection con = new clsConnection();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;

            try
            {

                SqlConnection sqlc = con.getConnection();
                query.CommandText = "UPDATE Mision SET nombre=@nombre, descripcion=@descripcion, creditos=@creditos, completada=@completada WHERE id=@id";

                query.Parameters.AddWithValue("id", mision.Id);
                query.Parameters.AddWithValue("nombre", mision.Nombre);
                query.Parameters.AddWithValue("creditos", mision.Creditos);
                query.Parameters.AddWithValue("completada", mision.Completada);

                query.Connection = sqlc;
                reader = query.ExecuteReader();

                reader.Close();
                con.closeConnection(ref sqlc);

            }
            catch(SqlException e)
            {
                throw e;
            }

            return reader.RecordsAffected;

        }

    }
}
