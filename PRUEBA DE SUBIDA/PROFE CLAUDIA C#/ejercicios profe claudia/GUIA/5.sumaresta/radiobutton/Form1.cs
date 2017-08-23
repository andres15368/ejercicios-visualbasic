using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b;
            a=int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);


            if (radioButton1.Checked == true)
            {

                int suma = a + b;
                Text = suma.ToString();

            }
            else
            {
                if (radioButton2.Checked == true)
                {

                    int resta = a - b;
                    Text = resta.ToString();

                }
            }

        }
    }
}
