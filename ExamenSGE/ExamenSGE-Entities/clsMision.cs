using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenSGE_Entities
{
    public class clsMision
    {

        private int id;
        private string nombre;
        private string descripcion;
        private int creditos;
        private bool completada;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public int Creditos
        {
            get
            {
                return this.creditos;
            }
            set
            {
                this.creditos = value;
            }
        }

        public bool Completada
        {
            get
            {
                return this.completada;
            }
            set
            {
                this.completada = value;
            }
        }

    }
}
