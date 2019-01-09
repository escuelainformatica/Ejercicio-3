using ProyectoWeb.Models;
using ProyectoWeb.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoWeb
{
    public partial class WebFormProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Producto prod=ProductoServicio.Crear(TextBox1,TextBox2);
            int calculo=ProductoServicio.Calcular(prod);
            Label1.Text=calculo.ToString();


        }
    }
}