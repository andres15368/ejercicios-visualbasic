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
    public partial class Intereses : Form
    {
        public Intereses()
        {
            InitializeComponent();
        }

        private void Intereses_Load(object sender, EventArgs e)
        {
            //un hombre desea //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b,respuesta,dinero;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            respuesta = a * b/100 ;

            if (respuesta >= 700000)
            {
                dinero = respuesta + a;
                MessageBox.Show("Puede reinvertir "+"su total de dinero es de:"+dinero);
          

                

            }
            else
            {
                MessageBox.Show("los intereses no son suficientes");
            }






        }
    }
}
