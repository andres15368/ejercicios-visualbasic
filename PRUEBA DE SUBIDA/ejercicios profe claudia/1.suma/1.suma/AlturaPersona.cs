using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.suma
{
    public partial class AlturaPersona : Form
    {
        public AlturaPersona()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(textBox1.Text);

            if (a<=1.50)
            {
                MessageBox.Show("Persona de estatura baja");

            }
            if (a>=1.51 && a<=1.70)
            {
                MessageBox.Show("Persona de estatura media");
            }
            if (a>=1.71)
            {
                MessageBox.Show("Persona de estatura alta");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
