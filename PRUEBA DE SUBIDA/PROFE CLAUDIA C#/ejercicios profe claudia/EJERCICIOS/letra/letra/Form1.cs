using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;

            a = Convert.ToString(textBox1.Text);

            if (a == "A")
            {
                MessageBox.Show("estudiante aprobado");
            }
            else
                MessageBox.Show("estudiante promedio");
        }
    }
}
