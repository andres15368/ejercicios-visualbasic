using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALEATORIO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NUMERO.Text  == ADIVINAR.Text )
  {
      MessageBox.Show ("FELICITACIONES, ADIVINO EL NUMERO, ENHORA BUENA"); 
        }
            else
             MessageBox.Show ("LO SIENTO, SU NUMERO NO ES CORRECTO, INTENTE DE NUEVO"); 
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random n  =new Random ();
            int numero = n.Next  (1,10);
            ADIVINAR.Text  = Convert.ToString(numero);
        }
        }
}
