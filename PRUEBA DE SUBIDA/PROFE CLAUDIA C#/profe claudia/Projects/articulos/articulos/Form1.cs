using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace articulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nombre;
            double c, co, cd;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("ingrese un valor");
            }

            else
            {
                nombre = int.Parse(textBox1.Text);
                c = double.Parse(textBox2.Text);
                co = double.Parse(textBox3.Text);
                cd = double.Parse(textBox4.Text);
                 
                if (c = 1)
                {
                    MessageBox.Show("su descuento es de el 10%");
                }

                   
        }
    }
}
