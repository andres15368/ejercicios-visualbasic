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
    public partial class orden_de_mayor_a_menor : Form
    {
        public orden_de_mayor_a_menor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);


            if (a>b)
            {
                MessageBox.Show("el orden es " + b + " y" + a);
            }

            if (a < b)
            {
                MessageBox.Show("el orden es " + a + " y" + b);
            }
        }
    }
}
