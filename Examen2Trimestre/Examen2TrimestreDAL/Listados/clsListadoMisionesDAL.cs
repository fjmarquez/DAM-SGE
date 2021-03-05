using Examen2TrimestreDAL.Conexion;
using Examen2TrimestreEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2TrimestreDAL.Listados
{
    public class clsListadoMisionesDAL
    {
        /// <summary>
        /// Funcion de la capa DAL que accedera a la base de datos y obtendra un listado de misiones que 
        /// aun esten pendientes de completas (completada = 0)
        /// </summary>
        /// <returns></returns>
        public List<Mision> getListadoMisionesPorCompletar()
        {

            List<Mision> listado = new List<Mision>();
            Mision mision;
            clsConexionDAL con = new clsConexionDAL();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;

            try
            {
                SqlConnection sqlc = con.getConnection();
                query.CommandText = "select id, nombre, descripcion, creditos, completada from misiones where completada = 0";
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        mision = new Mision();

                        mision.Id = ((int)reader["id"]);
                        mision.Nombre = ((string)reader["nombre"]);
                        mision.Descripcion = ((string)reader["descripcion"]);
                        mision.Creditos = ((int)reader["creditos"]);
                        mision.Completada = ((bool)reader["completada"]);

                        listado.Add(mision);
                    }
                }
                reader.Close();
                con.closeConnection(ref sqlc);
            }
            catch (SqlException e)
            {
                throw e;
            }

            return listado;
        }

    }
}
