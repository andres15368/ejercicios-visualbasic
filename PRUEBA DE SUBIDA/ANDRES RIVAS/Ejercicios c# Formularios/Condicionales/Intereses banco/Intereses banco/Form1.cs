using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intereses_banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, x,i, t;

            a = double.Parse(textBox1.Text);
            x = double.Parse(textBox2.Text);

            i = (a * x) / 100;

            textBox3.Text = i.ToString();

            t = (a + i);
            textBox4.Text = t.ToString();

            if (i >= 700000)
            {
                MessageBox.Show("¡Felicitaciones! Sus intereses superan los 700000 puede reinvertir");
            }
            else

                MessageBox.Show("¡Lo sentimos! Sus intereses no superan los 700000 no puede reinvertir");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
