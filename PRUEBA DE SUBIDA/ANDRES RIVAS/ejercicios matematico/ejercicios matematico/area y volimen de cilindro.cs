using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios_matematico
{
    public partial class area_y_volimen_de_cilindro : Form
    {
        public area_y_volimen_de_cilindro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r, h, al, ab, at, v;

            r = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);

            al = 2 * Math.PI * r * h;
            MessageBox.Show("el area lateral es:  " + al);

            ab = Math.PI * Math.Pow(r, 2);
           MessageBox.Show("el area de la base es: " + ab);

            at = 2*al + ab;
            MessageBox.Show("el area total es de: " + at);



            v = Math.PI * Math.Pow(r, 2)*h;
            MessageBox.Show("el volumen  del cilindro es de:  " + v);


        }
    }
}
