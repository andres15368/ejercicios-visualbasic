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
    public partial class seguros : Form
    {
        public seguros()
        {
            InitializeComponent();
        }

        private void seguros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;

            a = double.Parse(textBox1.Text);


            if (a < 50000)
            {
                b = a * 0.3;
                c = a + b;
                MessageBox.Show("usted debe cancelar el 3%  "  +b);
            
                textBox2.Text = b.ToString();
            }
            if (a > 50000)
            {
                b = a * 0.2;
                d = a + b;
                MessageBox.Show("usted debe cancelar el 2%" +b);
                textBox2.Text = d.ToString();
            }


        }
    }
}
// una compañia de seguros esta abriendo un deparatmento de finanzas
// y establecio una programa para captar clientes que consisten lo siguiente 
// si el monto pr el que se efectuo la fiansa es menos 50 mil la cota a pagar 
// sera por el 3% del monto  y si el monto es maypr que 50mil la cuota a pagara sera del 2% del monto 
// la fiansadora desea determinar  cual sera la cuota que debe de pagar el cliente 