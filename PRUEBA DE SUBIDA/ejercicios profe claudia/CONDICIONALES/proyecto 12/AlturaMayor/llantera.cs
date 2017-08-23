using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaMayor
{
    public partial class llantera : Form
    {
        public llantera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);

            if (a < 5)
            {
                MessageBox.Show("cada llanta tiene unprecio de 800000");
                b = 800000 * a;
                textBox2.Text = b.ToString();

            }
            if (a>=5)
            {

                MessageBox.Show("cada llanta tiene unprecio de 700000");
                b = 700000 * a;
                textBox2.Text = b.ToString();
            }
        }
    }
}



    