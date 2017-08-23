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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a = double.Parse(textBox1.Text);
            b= double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            d = (a + b + c) / 3;

            if(d<=3.4)
            {
                MessageBox.Show("Alumno reprobo con una definitiva de:" + d);
            }
            if (d>=3.5 && d<=5.0)
               {
                MessageBox.Show("Alumno Aprobo con una definitiva de:" + d);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
