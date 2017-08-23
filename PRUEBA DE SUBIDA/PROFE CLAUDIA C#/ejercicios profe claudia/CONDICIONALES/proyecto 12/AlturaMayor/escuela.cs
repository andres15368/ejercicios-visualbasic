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
    public partial class escuela : Form
    {
        public escuela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d,f;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if(b>=9)
                  {
                      c = a * 0.30;
                      d = a - c;
                      MessageBox.Show("Felicidades obtuvo un descuento del 30%    " + c);
                      textBox3.Text = d.ToString();
                  }

            if(b<9)
                  {
                c=a*0.10;
                d=a+c;
                MessageBox.Show("Debe cancelar el total de la colegiatura,incluyendo el 10% de iva");
                textBox3.Text = d.ToString();
                  }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
