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

namespace sumatoria30numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        string numero;
        long a;

        private void button1_Click(object sender, EventArgs e)
        {
            double sumatoria = 0;
            while (a <30)
            {
                numero = Interaction.InputBox("ingrese el numero");
                double b = Convert.ToDouble(numero);
                {
                    sumatoria = sumatoria + b;
                }
                a = a + 1;
            }
            MessageBox.Show("el resultado de la sumatoria es: " + sumatoria);
        }
    }
}
