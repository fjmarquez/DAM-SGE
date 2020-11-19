using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08ASPNETMVCDatosControlador03.Models
{
    public class clsPersona
    {
         public int idPersona { get; set; }
         public String nombre { get; set; }
         public String apellidos { get; set; }
         public DateTime fechaNacimiento { get; set; }
         public String direccion { get; set; }
         public String telefono { get; set; }
         public clsDepartamento dpto { get; set; }
        
        public clsPersona()
        {
            this.idPersona = 0;
            this.nombre = "Francisco";
            this.apellidos = "Pulido";
            this.fechaNacimiento = new DateTime().Date;
            this.direccion = "Sor Milagros 4";
            this.telefono = "666666666";
            this.dpto = new clsDepartamento(0, "prueba");
        }

        public clsPersona(int ID, String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono)
        {
            this.idPersona = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
        }


    }
}