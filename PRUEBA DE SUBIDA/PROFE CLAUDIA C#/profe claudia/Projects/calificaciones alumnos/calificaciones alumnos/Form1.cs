using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calificaciones_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c, d;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ingrese un valor ");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("ingrese un valor ");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("ingrese un valor ");
            }

            else
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                c = float.Parse(textBox3.Text);
                d = ((a + b + c) / 3);
            }

            if (d >= 70)
            {
                MessageBox.Show("usted aprobo");
            }
            if (d < 70)
            {
                MessageBox.Show("usted no aprobo");
            }
        }
    }
}
