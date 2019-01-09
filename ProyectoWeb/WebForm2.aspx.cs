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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Calculadora calc=new Calculadora();
            calc=CalculadoraServicio.Crear(TextBox1,TextBox2); 
            int suma=CalculadoraServicio.Sumar(calc);
            LabelResultado.Text=suma.ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Calculadora calc=new Calculadora();
            calc=CalculadoraServicio.Crear(TextBox1,TextBox2); 
            int restar=CalculadoraServicio.Restar(calc);
            LabelResultado.Text=restar.ToString();
        }
    }
}