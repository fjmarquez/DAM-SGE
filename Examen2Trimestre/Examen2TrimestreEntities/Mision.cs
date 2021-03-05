using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2TrimestreEntities
{
    public class Mision
    {

        #region Propiedades publicas

        private int id;
        private string nombre;
        private string descripcion;
        private int creditos;
        private bool completada;

        #endregion

        #region Contructores

        public Mision()
        {
            this.id = 0;
            this.nombre = "";
            this.descripcion = "";
            this.creditos = 0;
            this.completada = false;
        }

        public Mision(int id, string nombre, string descripcion, int creditos, bool completada)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.creditos = creditos;
            this.completada = completada;
        }

        #endregion

        #region Getters y setters

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

        #endregion

    }
}
