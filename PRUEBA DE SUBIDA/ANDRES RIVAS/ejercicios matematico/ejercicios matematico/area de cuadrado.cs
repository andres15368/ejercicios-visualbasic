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
    public partial class area_de_cuadrado : Form
    {
        public area_de_cuadrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;

            a = double.Parse(textBox1.Text);

            b = a * a * a * a;

            textBox2.Text = b.ToString();
        }
    }
}
