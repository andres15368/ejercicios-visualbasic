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
    public partial class edad : Form
    {
        public edad()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
          a= int.Parse(  textBox1.Text) ;

            if (a >= 18)
            {
                MessageBox.Show("USTED ES MAYOR DE EDAD");
            }
            else
            {
                MessageBox.Show("USTED ES MENOR DE EDAD");
            }

        }
    }
}
