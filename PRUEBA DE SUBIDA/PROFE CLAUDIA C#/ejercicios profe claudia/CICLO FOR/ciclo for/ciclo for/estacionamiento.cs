using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo_for
{
    public partial class estacionamiento : Form
    {
        public estacionamiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, d;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            int x=0;

            if(b-a<0)
            {
                x = 24 + (b - a);
            }
            else
            {
                x = b - a;
            }
           MessageBox.Show("total horas     "+x);
           
            d=1000;

                d=x*600-600+d;

             textBox3.Text=d.ToString();



            }



              

            }

            

        


          


        }
    