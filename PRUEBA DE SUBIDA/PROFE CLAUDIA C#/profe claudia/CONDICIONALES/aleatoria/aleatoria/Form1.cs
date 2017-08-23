using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aleatoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random m = new Random();
            int numero= m.Next(1,  10);
            Adivinar.Text = Convert.ToString(numero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Numero.Text == Adivinar.Text)
            {
                MessageBox.Show("felicidades adivino el numero");
            }
            else
            {
                MessageBox.Show("perdiste animal");
            }
        }
    }
}
