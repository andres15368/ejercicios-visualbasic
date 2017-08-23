using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
            

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            label6.Refresh();
            label6.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            label6.Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            label7.Refresh();
            label7.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            label7.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double he, hs, horaes, hpr;


            he = Convert.ToDouble(label6);
            hs = Convert.ToDouble(label7);

            horaes = (he - hs);
            hpr = 1000;
            hpr = (hs * 600 - 600 + hpr);
            MessageBox.Show("el monto a pagar es " + hpr + "" + hs + "horas");
        }
    }
}
