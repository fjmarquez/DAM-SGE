using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10ADONet01.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost, ActionName("Index")]
        public ActionResult IndexPost()
        {
            SqlConnection sqlc = new SqlConnection();

            try
            {
                sqlc.ConnectionString = "server=fjmarquez.database.windows.net;database=fjmarquez;uid=fjmarquez;pwd=Mitesoro1.";
                sqlc.Open();
                ViewBag.ConexionBD = "Conexion abierta correctamente";
            }
            catch(SqlException e)
            {
                ViewBag.ConexionBD = "Error";
            }

            return View("Index");
        }
    }
}