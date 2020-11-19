using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace _08ASPNETMVCDatosControlador03.Models
{
    public class clsDepartamento
    {

        public int idDepartamento { get; set; }
        public String nombreDepartamento { get; set; }

        public clsDepartamento()
        {
            this.idDepartamento = 0;
            this.nombreDepartamento = "DPTO PRUEBA";
        }

        public clsDepartamento(int i, string n)
        {
            this.idDepartamento = i;
            this.nombreDepartamento = n;
        } 
    }
}