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
    public partial class tresnumerosmayor : Form
    {
        public tresnumerosmayor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;


            a = int.Parse(textBox1.Text);
            b= int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);

            if (a>b &&a>c&& c>b )
            {
                MessageBox.Show(" Numero Mayor es:"+a+"Numero Menor es:"+b);
            }
            if(a>b && a>c && b>c)
            {
                MessageBox.Show(" Numero Mayor es:" + a + "Numero Menor es:" + c);
            }
            if(b>a && b>c && c>a)
            {
                MessageBox.Show(" Numero Mayor es:" + b+ "Numero Menor es:" + a);
            }
            if(b>a && b>c && a>c)
            {
                MessageBox.Show(" Numero Mayor es:" + b + "Numero Menor es:" + c);
            }
            if (c>a && c>b && a>b)
            {
                MessageBox.Show(" Numero Mayor es:" + c + "Numero Menor es:" + b);
            }
            if (c>a && c>b && b>a)
            {
                MessageBox.Show(" Numero Mayor es:" + c + "Numero Menor es:" + a);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
