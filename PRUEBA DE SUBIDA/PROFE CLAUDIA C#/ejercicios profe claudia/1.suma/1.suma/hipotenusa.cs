using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.suma
{
    public partial class hipotenusa : Form
    {
        public hipotenusa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,f;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            c = (a * a) + (b * b);
            f = Math.Sqrt(c);

            MessageBox.Show("La Hipotenusa del triangulo es:" + f);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
