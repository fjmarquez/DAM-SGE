using _10CRUDPersonasBL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10CRUDPersonasUI.Models
{
    public class clsPersonaConNombreDepartamento : clsPersona
    {

        private String nombreDepartamento;

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

        public clsPersonaConNombreDepartamento getPersonaConNombreDepartamento(clsPersona persona)
        {

            clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento();

            pConNombreDepartamento.Id = persona.Id;
            pConNombreDepartamento.Nombre = persona.Nombre;
            pConNombreDepartamento.Apellidos = persona.Apellidos;
            pConNombreDepartamento.Direccion = persona.Direccion;
            pConNombreDepartamento.Telefono = persona.Telefono;
            pConNombreDepartamento.Foto = persona.Foto;
            pConNombreDepartamento.IdDepartamento = persona.IdDepartamento;
            clsDepartamento departamento = new listadoDepartamentosBL().getDepartamentoPorID(persona.IdDepartamento);
            pConNombreDepartamento.NombreDepartamento = departamento.Departamento;

            return pConNombreDepartamento;
        }

    }
}
