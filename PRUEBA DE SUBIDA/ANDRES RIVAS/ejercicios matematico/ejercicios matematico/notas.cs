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
    public partial class notas : Form
    {
        public notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, total;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            total = (a + b + c) /3;

            if (total >=3)
            {
                MessageBox.Show("usted aprobo");
            }
            else
            {
                MessageBox.Show("usted reprobo");
            }



        }
    }
}
