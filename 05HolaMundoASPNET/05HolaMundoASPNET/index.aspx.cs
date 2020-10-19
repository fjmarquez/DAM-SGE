using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _05HolaMundoASPNET
{
    public partial class index : System.Web.UI.Page
    {
        private TextBox tbN;
        private Label lblN;
        private Label lblE;
        protected void Page_Load(object sender, EventArgs e)
        {
            tbN = (TextBox)txtNombre;
            lblN = (Label)lblSaludo;
            lblE = (Label)lblError;
        }


        /// <summary>
        /// Se ejecuta al pulsar sobre el boton saludar, y saluda o muestra error en funcion del contenido del TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            //Vacia los labels
            lblE.Text = "";
            lblN.Text = "";

            //Obtenemos el texto que contiene el TextBox asignado para recoger el nombre
            String txtN = tbN.Text;
            //Numero de caracteres introducidos en el Textbox asignado para recoger el nombre
            int lenghtTxt = txtN.Length;

            //Comprueba si el TextBox asginado para recoger el nombre esta vacio o no
            if (lenghtTxt == 0)
            {
                lblE.Text = "Debes introducir un nombre";
            }
            else
            {
                lblN.Text = "Hola " + txtN;
            }

            
        }
    }
}