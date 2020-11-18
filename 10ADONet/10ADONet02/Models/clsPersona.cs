using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10ADONet02.Models
{
    public class clsPersona
    {
        private int id;
        private byte[] foto;
        private String nombre, apellidos, direccion, telefono;
        private DateTime fechaNacimiento;
        private clsDepartamento departamento;



        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellidos
        {
            get
            {
                return apellidos;
            }
            set
            {
                apellidos = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }

        public clsDepartamento Departamento
        {
            get
            {
                return departamento;
            }
            set
            {
                departamento = value;
            }
        }

        public clsPersona(String nombre, String apellidos, DateTime fechaNacimiento, string direccion, string telefono, clsDepartamento departamento)
        {

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Departamento = departamento;
        }

        public clsPersona()
        {

            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now;
            this.Direccion = "";
            this.Telefono = "";
            this.Departamento = null;
        }

    }
}