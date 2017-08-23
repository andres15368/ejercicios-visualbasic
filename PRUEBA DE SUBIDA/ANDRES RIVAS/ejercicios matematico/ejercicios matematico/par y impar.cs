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
    public partial class par_y_inpar : Form
    {
        public par_y_inpar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);

            if (a %  2 == 0)
            {
                MessageBox.Show("el numero " + a + " es par");

            }
            else
            {
                MessageBox.Show("el numero " + a + " es impar");
            }

        }
    }
}
