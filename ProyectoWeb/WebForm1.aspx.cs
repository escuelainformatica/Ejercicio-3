using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// codigo por detras.

namespace ProyectoWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Text="Texto modificado";
            TextBox1.Text="carga de pagina";
        }

        // evento
        // un evento, es una funcion que se llama
        // bajo alguna interactividad
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text="Se hizo click en el boton";

            //Cliente cli=new Cliente();
            //cli.Nombre="John";

        }
    }
}