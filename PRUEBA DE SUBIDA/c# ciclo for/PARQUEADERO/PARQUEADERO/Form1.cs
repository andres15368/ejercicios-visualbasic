using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARQUEADERO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double he, hs, horaes, hpr1, hpr;


        he = Convert.ToDouble(TextBox1.Text);
        hs = Convert.ToDouble(TextBox2.Text);

        horaes = (hs - he);
        hpr1 = 1000;
        hpr = (horaes * 600 -  600 + hpr1);
        MessageBox.Show("el monto a pagar es " + hpr +  " "  + horaes + "horas");

            
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void he_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
