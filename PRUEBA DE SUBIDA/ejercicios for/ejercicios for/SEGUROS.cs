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
    public partial class SEGUROS : Form
    {
        public SEGUROS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a = double.Parse(textBox1.Text);


            if (a < 50000)
            {
                b = a * 0.3;
                c = a + b;
                MessageBox.Show("usted debe cancelar el 3%  " + b);

                textBox2.Text = b.ToString();
            }
            if (a > 50000)
            {
                b = a * 0.2;
                d = a + b;
                MessageBox.Show("usted debe cancelar el 2%" + b);
                textBox2.Text = d.ToString();
            }

        }
    }
}
