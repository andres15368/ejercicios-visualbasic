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
    public partial class empresa_constructora : Form
    {
        public empresa_constructora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int a, c,d,x;


         
           
              a = int.Parse(textBox1.Text);
              d = int.Parse(textBox3.Text);

               c = a * 10000;
               x = c * d;
               textBox2.Text = x.ToString();

               for (int i = 1;i<=d;i++)
               {

                   MessageBox.Show("valor a pagar por empleado:    " + i + "   horas" + "   con un total a pagar de:     " + c);


                 
               }
           
           

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
