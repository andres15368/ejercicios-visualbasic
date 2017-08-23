using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SALARIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string a;

        private void button1_Click(object sender, EventArgs e)
        {
            string n;
            double b, d,f, h;
            double suma = 0;




            n = textBox1.Text;
            b = double.Parse(textBox2.Text);


            for (int i=1; i<= b; i++)
            {
                a = Interaction.InputBox("INGRESE EL VALOR DEL AUTO NUMERO " + i);
                double c = Convert.ToDouble(a);

                suma = suma + c;
                textBox3.Text = suma.ToString();


            }







            



        }
    }
}
