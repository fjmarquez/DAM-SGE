﻿using _10CRUDPersonasDAL.Connection;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasDAL.Listados
{
    public class listadoDepartamentosDAL
    {

        /// <summary>
        ///  Funcion de la capa DAL, la cual accede directamente a la informacion de la BD Azure y obtiene un listado de departamentos 
        /// </summary>
        /// <returns></returns>
        public List<clsDepartamento> getListadoDepartamentos()
        {
            clsMyConnectionDAL con = new clsMyConnectionDAL();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;
            List<clsDepartamento> list = new List<clsDepartamento>();
            clsDepartamento departamento;

            try
            {
                SqlConnection sqlc = con.getConnection();
                query.CommandText = "SELECT ID, Nombre FROM Departamentos";
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        departamento = new clsDepartamento();

                        departamento.Id = (int)reader["ID"];
                        departamento.Departamento = (string)reader["Nombre"];

                        list.Add(departamento);
                    }
                }
                reader.Close();
                con.closeConnection(ref sqlc);
            }
            catch (SqlException e)
            {
                throw e;
            }


            return list;
        }


        /// <summary>
        ///  Funcion de la capa DAL, la cual accede directamente a la informacion de la BD Azure y obtiene toda la informacion sobre
        ///  el departamento cuyo id recibimos por parametros
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public clsDepartamento getDepartamentoPorID(int ID)
        {
            clsMyConnectionDAL con = new clsMyConnectionDAL();
            SqlCommand query = new SqlCommand();
            SqlDataReader reader;
            clsDepartamento departamento = new clsDepartamento(); ;

            try
            {
                SqlConnection sqlc = con.getConnection();
                query.CommandText = "SELECT ID, Nombre FROM Departamentos WHERE ID=" + ID;
                query.Connection = sqlc;
                reader = query.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        departamento.Id = (int)reader["ID"];
                        departamento.Departamento = (string)reader["Nombre"];
                       
                    }
                }
                reader.Close();
                con.closeConnection(ref sqlc);
            }
            catch (SqlException e)
            {
                throw e;
            }


            return departamento;
        }



    }
}