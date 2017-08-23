using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo_for
{
    public partial class promedio : Form
    {
        public promedio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,suma=0;

            a = int.Parse(textBox1.Text);
        

            for (int i = 1; i <= a; i++)
            {

                MessageBox.Show("numero " + i);

                suma = suma + i;
            }

            textBox2.Text = suma.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
