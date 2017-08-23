using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expendio_de_naranjas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, c, d;

            a = Double.Parse(textBox1.Text);
            b = Double.Parse(textBox2.Text);

            if (a<= 10)
            {
                c = 0;
                textBox3.Text = c.ToString();
                MessageBox.Show("No obtiene ningún tipo de descuento");
                d = b - c;
                textBox4.Text = d.ToString();
            }

            if (a > 10)
            {
                c = b*0.15;
                textBox3.Text = c.ToString();
                MessageBox.Show("Has obtenido el 15% de descuento sobre el valor total");
                d = b - c;
                MessageBox.Show("Ganancia para la tienda" + d);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
