using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almacen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, descuento;

            if (textBox1.Text == "")
            {
                MessageBox.Show("ingrese un valor");
            }
            else
            {
                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);
                descuento = (a*0.20);
            }
            if (a <= 99999)
            {
                MessageBox.Show("usted no tiene descuento");
            }
                if (a >= 100000)
                {
                    MessageBox.Show("")

        }
    }
}
