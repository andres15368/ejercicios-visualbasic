using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaMayor
{
    public partial class Empresa_de_fabrica : Form
    {
        public Empresa_de_fabrica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double  b, c,d,j,h;
             b = double.Parse(textBox2.Text);


            if (b>=500000)
            {
              
                d = b * 0.55;
               label4.Text = d.ToString();

             
                j = b* 0.30;
                label5.Text = j.ToString();

                h = b*0.15;
                label7.Text = h.ToString();



            }
            if (b < 500000)
            {
                c = b;
                label10.Text = c.ToString();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
