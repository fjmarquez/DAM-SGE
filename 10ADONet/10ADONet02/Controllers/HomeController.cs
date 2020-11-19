using _10ADONet02.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10ADONet02.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {

            clsMyConnection con = new clsMyConnection();
            SqlCommand consulta = new SqlCommand();
            SqlDataReader lector;
            List<clsPersona> listadoPersonas = new List<clsPersona>();
            clsPersona persona;

                

            try
            {
                
                SqlConnection sqlc = con.getConnection();
                //con.closeConnection(ref sqlc);
                consulta.CommandText = "SELECT ID, Nombre, Apellidos, FechaNacimiento, Direccion, Telefono, IDDepartamento, Foto FROM Personas";
                /*consulta.CommandText =
                    "select p.ID, p.Nombre, p.Apellidos, p.FechaNacimiento, p.Direccion, " +
                    "p.Telefono, p.IDDepartamento, d.Nombre from Personas as p inner join " +
                    "Departamentos as don p.IDDepartamento = d.ID";
                */
                consulta.Connection = sqlc;
                lector = consulta.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        persona = new clsPersona();
                        persona.Id = (int)lector["ID"];
                        persona.Nombre = (string)lector["Nombre"];
                        if(lector["Apellidos"] != System.DBNull.Value)
                        {
                            persona.Apellidos = (string)lector["Apellidos"];
                        }
                        if (lector["FechaNacimiento"] != System.DBNull.Value)
                        {
                            persona.FechaNacimiento = (DateTime)lector["FechaNacimiento"];
                        }
                        if (lector["Foto"] != System.DBNull.Value)
                        {
                            persona.Foto = (byte[])lector["Foto"];
                        }
                        if (lector["Direccion"] != System.DBNull.Value)
                        {
                            persona.Direccion = (string)lector["Direccion"];
                        }
                        if (lector["Telefono"] != System.DBNull.Value)
                        {
                            persona.Telefono = (string)lector["Telefono"];
                        }
                        if (lector["IDDepartamento"] != System.DBNull.Value)
                        {
                            persona.Departamento = new clsDepartamento();
                            persona.Departamento.Id = (int)lector["IDDepartamento"];
                            //persona.Departamento.Departamento = (string)lector["d.Nombre"];
                        }


                        listadoPersonas.Add(persona);
                    }
                }
                lector.Close();
                con.closeConnection(ref sqlc);

            }catch (SqlException e)
            {
                ViewBag.errorBD = e.ToString();
            }

            return View("ListadoPersonas", listadoPersonas);
        }
    }
}