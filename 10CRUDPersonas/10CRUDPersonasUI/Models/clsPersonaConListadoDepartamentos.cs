using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10CRUDPersonasUI.Models
{
    public class clsPersonaConListadoDepartamentos : clsPersona
    {

        private List<clsDepartamento>  listDepartamentos;

     

        public List<clsDepartamento> ListDepartamentos
        {
            get
            {
                return listDepartamentos;
            }
            set
            {
                listDepartamentos = value;
            }
        }

        public clsPersonaConListadoDepartamentos(clsPersona persona, List<clsDepartamento> listDepartamentos)
        {

            this.Nombre = persona.Nombre;
            this.Apellidos = persona.Apellidos;
            this.FechaNacimiento = persona.FechaNacimiento;
            this.Direccion = persona.Direccion;
            this.Telefono = persona.Telefono;
            this.ListDepartamentos = listDepartamentos;
            this.IdDepartamento = persona.IdDepartamento;
        }

        public clsPersonaConListadoDepartamentos()
        {

            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Now;
            this.Direccion = "";
            this.Telefono = "";
            this.ListDepartamentos = null;
            this.IdDepartamento = 0;
        }

    }
}