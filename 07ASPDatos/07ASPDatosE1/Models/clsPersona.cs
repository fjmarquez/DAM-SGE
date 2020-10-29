using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _07ASPDatosE1.Models
{
    public class clsPersona
    {

        public int IDPersona { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }

        public clsPersona(int ID, string nombre, string apellidos, string direccion, string telefono)
        {
            this.IDPersona = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public clsPersona()
        {
        }



    }
}