using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10CRUDPersonasUI.Models
{
    public class clsPersonaConNombreDepartamento
    {
        private int id;
        private byte[] foto;
        private String nombre, apellidos, direccion, telefono;
        private DateTime fechaNacimiento;
        private String nombreDepartamento;
        private int idDepartamento;

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

        public String NombreDepartamento
        {
            get
            {
                return nombreDepartamento;
            }
            set
            {
                nombreDepartamento = value;
            }
        }

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }
            set
            {
                idDepartamento = value;
            }
        }

        public clsPersonaConNombreDepartamento(String nombre, String apellidos, DateTime fechaNacimiento, string direccion, string telefono, string nombreDepartamento, int idDepartamento)
        {

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.NombreDepartamento = nombreDepartamento;
            this.IdDepartamento = idDepartamento;
        }

        public clsPersonaConNombreDepartamento()
        {

            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now;
            this.Direccion = "";
            this.Telefono = "";
            this.NombreDepartamento = "";
            this.IdDepartamento = 0;
        }

    }
}
