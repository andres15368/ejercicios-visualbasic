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
    public partial class organizar_mayor_menor : Form
    {
        public organizar_mayor_menor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;

            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);

            if (a > b)
            {
                textBox3.Text = b.ToString();
                textBox4.Text = a.ToString();
            }

            if (b>a)
            {
                textBox3.Text = a.ToString();
                textBox4.Text = b.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
