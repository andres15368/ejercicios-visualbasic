using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablas_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox1.Items.Clear();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, tabla, resultado;

            tabla = int.Parse(textBox1.Text);

            listBox1.Items.Clear();

            for (num=1; num<=10;num++) 
            {
                resultado= num * tabla;
                listBox1.Items.Add(tabla+"x"+num+"="+resultado);

            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
