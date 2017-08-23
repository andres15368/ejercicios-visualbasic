using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_for
{
    public partial class SUPERMERCADO : Form
    {
        public SUPERMERCADO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if (b < 74)
            {
                c = a * 0.15;
                MessageBox.Show("gano un descuento del 15%");
                textBox3.Text = c.ToString();
                d = a - c;
                textBox4.Text = d.ToString();

            }
            if (b >= 74)
            {
                c = a * 0.20;
                MessageBox.Show("gano un descuento del 20%");
                textBox3.Text = c.ToString();
                d = a - c;
                textBox4.Text = d.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }
    }
}
