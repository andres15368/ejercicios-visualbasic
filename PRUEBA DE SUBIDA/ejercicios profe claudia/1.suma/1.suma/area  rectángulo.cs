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
    public partial class area__rectángulo : Form
    {
        public area__rectángulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a,b,h;

            b =Double.Parse(textBox1.Text);
            h = Double.Parse(textBox2.Text);

            a = b * h;

            MessageBox.Show("El area del rectangulo es: " + a + " m2 ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
