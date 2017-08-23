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
    public partial class areadecuadrado : Form
    {
        public areadecuadrado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b;

            a = double.Parse(textBox1.Text);

            b = a * a ;

            MessageBox.Show("el area del cuadrado es:    " + b + "   m2");
        }
    }
}
