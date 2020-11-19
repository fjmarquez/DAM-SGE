using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace _08ASPNETMVCDatosControlador03.Models
{
    [Bind(Include= "idPersona, nombre, apellidos, fechaNacimiento, direccion, telefono")]
    public class clsPersona
    {
<<<<<<< Updated upstream

        [HiddenInput(DisplayValue = false)]
        [Display(Name ="ID")]
        public int idPersona { get; set; }
        
        
        [Required(ErrorMessage = "The {0} field is required.")]
        [Display(Name = "Nombre")]
        [DataType(DataType.Text, ErrorMessage = "The {0} field must be text.")]
        public String nombre { get; set; }
        
        
        
        [Required(ErrorMessage = "The {0} field is required."), MaxLength(40)]
        [Display(Name = "Apellidos")]
        [DataType(DataType.Text, ErrorMessage = "The {0} field must be text.")]
        public String apellidos { get; set; }
        
        
        [Required(ErrorMessage = "The {0} field is required."), DisplayFormat(DataFormatString = "{0:d}")]
        [Display(Name = "FechaNacimiento")]
        public DateTime fechaNacimiento { get; set; }
        
        
        [Required(ErrorMessage = "The {0} field is required."), MaxLength(200)]
        [Display(Name = "Direccion")]
        //no consigo establecer el formato corto para las fechas
        public String direccion { get; set; }
        
        
        [Display(Name = "Telefono")]
        [RegularExpression(@"(\+34|0034|34)?[ -]*(6|7)([0-9]){2}[ -]?(([0-9]){2}[ -]?([0-9]){2}[ -]?([0-9]){2}|([0-9]){3}[ -]?([0-9]){3})")]
        public String telefono { get; set; }
        

=======
         public int idPersona { get; set; }
         public String nombre { get; set; }
         public String apellidos { get; set; }
         public DateTime fechaNacimiento { get; set; }
         public String direccion { get; set; }
         public String telefono { get; set; }
        
>>>>>>> Stashed changes
        public clsPersona()
        {
            this.idPersona = 0;
            this.nombre = "Francisco";
            this.apellidos = "Pulido";
            this.fechaNacimiento = new DateTime().Date;
            this.direccion = "Sor Milagros 4";
            this.telefono = "666666666";
        }

        public clsPersona(int ID, String nombre, String apellidos, DateTime fechaNacimiento, String direccion, String telefono)
        {
            this.idPersona = ID;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.direccion = direccion;
            this.telefono = telefono;
        }


    }
}