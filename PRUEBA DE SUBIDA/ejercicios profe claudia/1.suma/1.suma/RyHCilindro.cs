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
    public partial class RyHCilindro : Form
    {
        public RyHCilindro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double area, h, r, v;

            r = double.Parse(textBox1.Text);
           h = double.Parse(textBox2.Text);

            area = 2 * Math.PI * r * h;
            v = Math.PI * Math.Pow(r,2) * h;

            MessageBox.Show("El area del cilindro es:   " + area + " y su volumen es:   " + v);
        }
    }
}
