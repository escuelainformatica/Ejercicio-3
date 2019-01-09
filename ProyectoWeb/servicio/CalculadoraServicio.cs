using ProyectoWeb.Models;
using System;
using System.Web.UI.WebControls;

namespace ProyectoWeb.servicio
{
    public class CalculadoraServicio
    {
        private int campo;
        public int Propiedad {set; get;}

        // nunca.  Esto no es thread-safe
        private static int campoEstado;

        public static Calculadora Crear(TextBox texto1,
            TextBox texto2)
        {
            Calculadora resultado=new Calculadora();
            resultado.Numero1=Convert.ToInt32(texto1.Text);
            resultado.Numero2=Convert.ToInt32(texto2.Text);
            return resultado;
        }

        public static int Sumar(Calculadora calc)
        {
            int r=0;
            r=calc.Numero1+calc.Numero2;
            return r;
        }
        public static int Restar(Calculadora calc)
        {
            int r=0;
            r=calc.Numero1-calc.Numero2;
            return r;
        }

    }
}