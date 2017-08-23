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

namespace sumatoria_de_5
{
    public partial class vendedores : Form
    {
        public vendedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nom;
            double p, auto;
            int v=int.Parse(textBox1.Text);
            long i = 1;


            while (i=v)  

          
            {

                nom = Interaction.InputBox("Digite nombre vendedor:", "Datos", " ", 100, 50);
                string n = Convert.ToString(nom);

            }
        }
    }
}
