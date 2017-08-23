using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabla_de_multiplicar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador, tabla, M;
            tabla = int.Parse (textBox1.Text);
            for (contador = 1; contador <= 12; contador++) 
                
{
 
                    M = tabla * contador;
                    listBox1.Items.Add
                        (tabla + "*" + contador + "=" + M);
}
        }
    }
}
