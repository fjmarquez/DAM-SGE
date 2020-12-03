using ExamenSGE_DAL.ConnectionDAL;
using ExamenSGE_Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSGE_DAL.ListadosDAL
{
    public class clsListadoMisionesDAL
    {

        /// <summary>
        /// Esta funcion accedera directamente a la BD y obtendra una determinada mision, cuyo id coincidad con el recibido.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsMision getMision(int id)
        {
 
            clsConnection con = new clsConnection();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;
            clsMision mision = new clsMision();

            try
            {

                SqlConnection sqlc = con.getConnection();
                query.CommandText = "SELECT id, nombre, descripcion, creditos, completada FROM Misiones WHERE id = @id";
                query.Parameters.AddWithValue("id", id);
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        mision = new clsMision();

                        mision.Id = (int)reader["id"];
                        mision.Nombre = (string)reader["nombre"];
                        mision.Descripcion = (string)reader["descripcion"];
                        mision.Creditos = (int)reader["creditos"];
                        mision.Completada = (bool)reader["completada"];

                    }

                }

                reader.Close();
                con.closeConnection(ref sqlc);

            }
            catch(SqlException e)
            {

                throw e;

            }

            return mision;
        }

        /// <summary>
        /// Esta funcion accedera directamente a la BD y obtendra un listado de todas las misiones que aun esten por completar,
        /// es decir que su columna 'completada' tenga valor 0
        /// </summary>
        /// <returns></returns>
        public List<clsMision> getListadoMisionesPorCompletar()
        {
            

            clsConnection con = new clsConnection();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;
            List<clsMision> list = new List<clsMision>();
            clsMision mision;

            try
            {

                SqlConnection sqlc = con.getConnection();
                query.CommandText = "SELECT id, nombre, descripcion, creditos, completada FROM Misiones WHERE completada = 0";
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        mision = new clsMision();

                        mision.Id = (int)reader["id"];
                        mision.Nombre = (string)reader["nombre"];
                        mision.Descripcion = (string)reader["descripcion"];
                        mision.Creditos = (int)reader["creditos"];
                        mision.Completada = (bool)reader["completada"];


                        list.Add(mision);
                    }

                }

                reader.Close();
                con.closeConnection(ref sqlc);

            }
            catch(SqlException e)
            {
                throw e;
            }


            return list;
        }

    }
}
