using _10CRUDPersonasBL.Listados;
using _10CRUDPersonasEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10CRUDPersonasUI.Models
{
    public class clsListadoPersonasConNombreDepartamento
    {

        public List<clsPersonaConNombreDepartamento> getListadoPersonasConNombreDepartamento (List<clsPersona> list)
        {

            List<clsPersonaConNombreDepartamento> listConNombreDepartamento = new List<clsPersonaConNombreDepartamento>();

            foreach (clsPersona p in list)
            {
                clsPersonaConNombreDepartamento pConNombreDepartamento = new clsPersonaConNombreDepartamento();

                pConNombreDepartamento.Id = p.Id;
                pConNombreDepartamento.Nombre = p.Nombre;
                pConNombreDepartamento.Apellidos = p.Apellidos;
                pConNombreDepartamento.Direccion = p.Direccion;
                pConNombreDepartamento.Telefono = p.Telefono;
                pConNombreDepartamento.Foto = p.Foto;
                pConNombreDepartamento.IdDepartamento = p.IdDepartamento;
                clsDepartamento departamento = new listadoDepartamentosBL().getDepartamentoPorID(p.IdDepartamento);
                pConNombreDepartamento.NombreDepartamento = departamento.Departamento;

                listConNombreDepartamento.Add(pConNombreDepartamento);


            }

            return listConNombreDepartamento;
        }

        

    }
}