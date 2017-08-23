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
    public partial class notasnumericas : Form
    {
        public notasnumericas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);

            if (a>=19 && a<=20)
            {
                MessageBox.Show("Su nota es: A");
            }
            if(a>=16 && a<=17)
            {
                MessageBox.Show("Su nota es: B");

            }
            if (a>=13 && a<=14)
            {
                MessageBox.Show("Su nota es: C ");
            }
            if (a>=10 && a<=11)
            {
                MessageBox.Show("Su nota es: D");
            }
            if (a>=1 && a<=9)
                MessageBox.Show("Su nota es: E");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
