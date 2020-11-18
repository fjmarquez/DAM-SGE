using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _10ADONet02.Models
{
    public class clsDepartamento
    {

        private int id;
        private string departamento;

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

        public string Departamento
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

        public clsDepartamento (int id, string departamento)
        {
            this.Id = id;
            this.Departamento = departamento;
        }

        public clsDepartamento()
        {
            this.Id = 0;
            this.Departamento = "";
        }
    }
}