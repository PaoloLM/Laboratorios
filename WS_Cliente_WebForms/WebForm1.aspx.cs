using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WS_Cliente_WebForms.ServiceReference;

namespace WS_Cliente_WebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebServiceSoapClient servicio = new WebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = servicio.HolaMundo();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = servicio.Adios();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox2.Text);
            double num2 = Convert.ToDouble(TextBox3.Text);
            TextBox4.Text = (servicio.Sumar(num1, num2)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox5.Text);
            ListBox1.Items.Add(servicio.Tabla(num1));
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Add(servicio.Bisiestos(Convert.ToInt32(TextBox6.Text), Convert.ToInt32(TextBox7.Text)));
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int tipo = DropDownList1.SelectedIndex + 1;
            double numero1 = Convert.ToDouble(TextBox8.Text);
            double numero2 = Convert.ToDouble(TextBox9.Text);
            TextBox11.Text = (servicio.Operaciones(tipo, numero1, numero2)).ToString();
        }
    }
}