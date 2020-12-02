using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10CRUDPersonasEntities
{
    public class clsPersona
    {
        private int id;
        private byte[] foto;
        private String nombre, apellidos, direccion, telefono;
        private DateTime fechaNacimiento;
        private int idDepartamento;


        [Display(Name ="Id")]
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

        [Display(Name = "Foto")]
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

        [Display(Name = "Nombre")]
        [Required]
        [MaxLength(50), MinLength(3)]
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

        [Display(Name = "Apellidos")]
        [MaxLength(80), MinLength(3)]

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

        [Display(Name = "FechaNacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
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

        [Display(Name = "Direccion")]
        [MaxLength(100), MinLength(3)]
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

        [Display(Name = "Telefono")]
        [RegularExpression("^34(?:6[0-9]|7[1-9])[0-9]{7}$", ErrorMessage = "Telefono is required and must be properly formatted.")]
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

        [Required]
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

        public clsPersona(int id, String nombre, String apellidos, DateTime fechaNacimiento, string direccion, string telefono, int idDepartamento)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.IdDepartamento = idDepartamento;
        }

        public clsPersona()
        {
            this.Id = 0;
            this.Nombre = "";
            this.Apellidos = "";
            this.FechaNacimiento = DateTime.Today;
            this.Direccion = "";
            this.Telefono = "";
            this.IdDepartamento = 0;
        }

    }
}
