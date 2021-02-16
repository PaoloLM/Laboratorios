using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WS_Cliente_Desktop_Lizarraga.ServiceReference;

namespace WS_Cliente_Desktop_Lizarraga
{
    public partial class Form1 : Form
    {
        WebServiceSoapClient servicio = new WebServiceSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        //METODO DE HOLA MUNDO
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            txtvizualizar.Text = servicio.HolaMundo();
        }

        //METODO MENSAJE DE ADIOS
        private void btnAdios_Click(object sender, EventArgs e)
        {
            txtAdios.Text = servicio.Adios();
        }

        //METODO DE TABLA DE MULTIPLICAR
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos para la tabla", "Error..");
            }
            else
            {
                lvver.Clear();
                lvver.Items.Add(servicio.Tabla(Convert.ToInt32(txtnumero.Text)));
            }            
        }

        //METODO DE SUMA
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("") && textBox3.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos para la suma","Error..");
            }
            else
            {
                textBox1.Text = (servicio.Sumar(Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text))).ToString();
            }
            
        }

        //METODO AÑOS BISIESTOS
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text.Equals("") && textBox5.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos para el calculo", "Error..");
            }
            else
            {
                if (Convert.ToInt32(textBox5.Text) >= Convert.ToInt32(textBox4.Text))
                {
                    MessageBox.Show("Años ingresados incorrectos", "Error..");
                }
                else
                {
                    listView1.Clear();
                    listView1.Items.Add(servicio.Bisiestos(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text)));
                }                
            }
            
        }

        //METODO OPERACIONES ARITMETICAS
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text.Equals("") && textBox7.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos para la operacion", "Error..");
            }

            else
            {
                if (!comboBox1.Text.Equals(""))
                {
                    string tipo = comboBox1.Text;
                    double numero1 = Convert.ToDouble(textBox7.Text);
                    double numero2 = Convert.ToDouble(textBox6.Text);

                    if (tipo == "Suma")
                    {
                        textBox8.Text = (servicio.Operaciones(1, numero1, numero2)).ToString();
                    }
                    else if (tipo == "Resta")
                    {
                        textBox8.Text = (servicio.Operaciones(2, numero1, numero2)).ToString();
                    }
                    else if (tipo == "Multiplicacion")
                    {
                        textBox8.Text = (servicio.Operaciones(3, numero1, numero2)).ToString();
                    }
                    else if (tipo == "Division")
                    {
                        textBox8.Text = (servicio.Operaciones(4, numero1, numero2)).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Combo de operaciones vacio", "Error..");
                }              
            }            
        }
    }
}
