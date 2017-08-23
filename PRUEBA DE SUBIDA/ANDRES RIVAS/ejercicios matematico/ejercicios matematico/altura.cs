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
    public partial class altura : Form
    {
        public altura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;

            a = double.Parse(textBox1.Text);
            if (a <=150 )
            {
                MessageBox.Show("su altura es baja ");
            }

            if (a >= 151 && a <= 170)
            {
                MessageBox.Show("su altura es media ");
            }

            if (a  >= 171)
            {
                MessageBox.Show("su altura es alta ");
            }
        }
    }
}
