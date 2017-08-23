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
    public partial class arearectangulo : Form
    {
        public arearectangulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a,b,h;
            b = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);


            a = b * h;

            MessageBox.Show("el area del rectangulo es:  " + a + "metros cuadrados");



        }
    }
}
