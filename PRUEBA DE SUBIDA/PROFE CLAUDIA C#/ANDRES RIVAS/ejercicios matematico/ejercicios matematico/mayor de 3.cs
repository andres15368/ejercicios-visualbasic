using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_matematico
{
    public partial class mayor_de_3 : Form
    {
        public mayor_de_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);


            if (a > b && a> c)
            {

                textBox4.Text = a.ToString();
            }
            if (b > a  && b> c)
            {

                textBox4.Text = b.ToString();
            }

            if (c> a && c > b)
            {
                textBox4.Text = c.ToString();
            }
        }
    }
}
