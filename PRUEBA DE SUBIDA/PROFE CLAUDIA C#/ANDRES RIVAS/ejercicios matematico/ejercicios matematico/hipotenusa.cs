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
    public partial class hipotenusa : Form
    {
        public hipotenusa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, a, b,d;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            c = (a * a) + (b * b);

            d = Math.Sqrt(c);

            textBox3.Text = d.ToString();
        }
    }
}
