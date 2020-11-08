using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _08ASPNETMVCDatosControlador03.Models
{
    public class clsPersona
    {
         int idPersona { get; set; }
         String nombre { get; set; }
         String apellidos { get; set; }
         DateTime fechaNacimiento { get; set; }
         String direccion { get; set; }
         String telefono { get; set; }

        public clsPersona()
        {
            this.idPersona = 0;
            this.nombre = "Francisco";
            this.apellidos = "Pulido";
            this.fechaNacimiento = new DateTime().Date;
            this.direccion = "Sor Milagros 4";
            this.telefono = "666666666";
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