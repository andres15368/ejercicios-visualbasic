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
    public partial class supermercado : Form
    {
        public supermercado()
        {
            InitializeComponent();
        }

       private void supermercado_Load(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,d;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if ( b< 74)
            {
                c= a*0.15;
                MessageBox.Show("gano un descuento del 15%");
                textBox3.Text = c.ToString();
                    d= a-c;
                textBox4.Text = d.ToString();

            }
            if (b>= 74)
            {
                c = a * 0.20;
                MessageBox.Show("gano un descuento del 20%");
                textBox3.Text = c.ToString();
                d = a - c;
                textBox4.Text = d.ToString();
            }
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


























//mediante la cual al cliente obtiene 
//* obtiene un descuento dependiendo de un numero que se escpje a lasar
//si el numero ecojido es menor 74 el descuento es del 15% sobre el totalñ de la compra si es mayor ygual a 74 el descuento es del 20% obtener cuanto dinero se le descuenta 