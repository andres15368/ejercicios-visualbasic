using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace zoologico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
          

            a = Convert.ToString(textBox1.Text);
            double n, p, q;

            n = Convert.ToDouble(textBox2.Text);
            p = Convert.ToDouble(textBox3.Text);
            q = Convert.ToDouble(textBox4.Text);

            if (a == "elefante")
            {
                MessageBox.Show("usted selecciono     " + a + "    la muestra fue tomada a 20 de ellos ");




                double por, por1, por2;
                por = n * 0.20;
                textBox5.Text = por.ToString();
               
                por1 = p * 0.20;
                textBox6.Text = por1.ToString();

                por2 = q * 0.20;
                textBox7.Text = por2.ToString();
            }
                

                    if (a == "jirafas")
                    {
                        MessageBox.Show("usted selecciono     " + a + "    la muestra fue tomada a 15 de ellas ");


                     

                            double por,por1,por2;

                            por = n * 0.15;
                            textBox5.Text = por.ToString();
                        


                            por1= p * 0.15;
                            textBox6.Text = por1.ToString();
                      
                        
                            por2 = q * 0.15;
                            textBox7.Text = por2.ToString();
                        }




                    if (a == "chinpanses")
                    {

                        MessageBox.Show("usted selecciono     " + a + "    la muestra fue tomada a 40 de ellos ");


                        double por, por1, por2;
                        por = n * 0.40;
                        textBox5.Text = por.ToString();


                        por1 = p * 0.40;
                        textBox6.Text = por1.ToString();


                        por2 = q * 0.40;
                        textBox7.Text = por2.ToString();


                    }

                        
                    

                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        }
    }

