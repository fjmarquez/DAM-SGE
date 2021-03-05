using Examen2TrimestreDAL.Conexion;
using Examen2TrimestreEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2TrimestreDAL.Handlers
{
    public class clsHandlerMisiones
    {

        /// <summary>
        /// Funcion de la capa DAL que recibira una mision por parametros y actualizara sus registros en la base de datos
        /// </summary>
        /// <param name="mision"></param>
        /// <returns></returns>
        public int actualizarMision(Mision mision)
        {

            clsConexionDAL con = new clsConexionDAL();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;

            try
            {
                SqlConnection sqlc = con.getConnection();
                query.CommandText = "UPDATE misiones SET nombre=@nombre, descripcion=@descripcion, creditos=@creditos, completada=@completada WHERE id=@id";

                query.Parameters.AddWithValue("id", mision.Id);
                query.Parameters.AddWithValue("nombre", mision.Nombre);
                query.Parameters.AddWithValue("descripcion", mision.Descripcion);
                query.Parameters.AddWithValue("creditos", mision.Creditos);
                query.Parameters.AddWithValue("completada", mision.Completada);

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
