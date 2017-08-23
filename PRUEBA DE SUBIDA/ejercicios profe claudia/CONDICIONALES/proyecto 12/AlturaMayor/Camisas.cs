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
    public partial class Camisas : Form
    {
        public Camisas()
        {
            InitializeComponent();
        }

        private void Camisas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,d,f;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            if (a <= 3)
            {
                c = (b * 3); // valor camisas
                d = c * 0.10;
                f = c - d;
                MessageBox.Show("tiene un descuento del 10%   " + d);
                label4.Text = f.ToString();
            }

            if (a > 3)
            {
                c = (b * a);
                d = c * 0.20;
                f = c - d;
                MessageBox.Show("tiene un descuento del 20%   " + d);
                label4.Text = f.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Camisas frm2 = new Camisas();
            frm2.ShowDialog();
            
        

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
