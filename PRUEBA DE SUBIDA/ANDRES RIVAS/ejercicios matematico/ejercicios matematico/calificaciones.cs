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
    public partial class calificaciones : Form
    {
        public calificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            a = int.Parse(textBox1.Text);

            if (a >= 19 && a>=20)
            {
                MessageBox.Show(" su nota es A");
            }
            else

            if (a >= 16 && a <=18)
            {
                MessageBox.Show(" su nota es B");
            }

            if (a >= 13 && a <= 15)
            {
                MessageBox.Show(" su nota es c");
            }


            if (a >= 10 && a <= 12)
            {
                MessageBox.Show(" su nota es D");
            }

            if (a >= 1 && a <= 9)
            {
                MessageBox.Show(" su nota es E");
            }
        }
    }
}
