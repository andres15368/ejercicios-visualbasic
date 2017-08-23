using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace suma_de_heterigeneos_con_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d, resultado, multiplicacion;
            int opc;
            if (textBox5.Text == "")
            {
                MessageBox.Show("debe elegir una opcion a realizar");
            }
            else
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                c = int.Parse(txtC.Text);
                d = int.Parse(txtD.Text);
                opc = int.Parse(textBox5.Text);

                switch (opc)
                {
                    case 1:
                        {
                            if (c == d)
                            {
                                multiplicacion = a + b;
                                resultado = d = c;
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                            }
                            break;
                        }
                    case 2:
                        {
                            if (c == d)
                            {
                                multiplicacion = (a - b);
                                resultado = (c = d);
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();            
                            }
                            else
                            {
                                MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (c == d)
                            {
                                multiplicacion = (a * b);
                                resultado = (c * d);
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();        
                            }
                            else
                            {
                                MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                            }
                            break;
                        }
                    case 4:
                        {
                            if (c == d)
                            {
                                multiplicacion = (a * d);
                                resultado = (c * b);
                                cajaresultado.Text = multiplicacion.ToString();
                                textBox2.Text = resultado.ToString();
                            }
                            else
                            {
                                MessageBox.Show("DEBE INGRESAR LOS DENOMINADORES IGUALES YA QUE ES UNA FRACCION HOMOGENEA");
                            }
                            break;
                        }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            textBox5.Clear();
            textBox2.Clear();
            cajaresultado.Clear();
        }
    }
}
