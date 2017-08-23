using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayor_de_3_NUMEROS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if ( textBox1.Text == "")
   {
                MessageBox.Show ("ERROR INGRESE UN VALOR");
 }
            else
{
                a = double.Parse (textBox1.Text ); 
                b = double.Parse (textBox2.Text ); 
                c = double.Parse (textBox3.Text ); 

                if (a > b && a > c && b >c)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + a + (" EL NUMERO  MENOR ES") + c );
                    }
                if (a > b && a > c && b >b)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + a + (" EL NUMERO  MENOR ES") + b );
                    }
                if (b > b && a > c && a >c)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + b + (" EL NUMERO  MENOR ES") + c );
                    }
                if (b > a && b > c && c >a)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + b + (" EL NUMERO  MENOR ES") + a );
                    }
                if (c > a && c > b && b >a)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + c + (" EL NUMERO  MENOR ES") + a );
                    }
                if (c > a && c > b && a >b)
                    {
                    MessageBox.Show (("EL NUMERO MAYOR ES") + c + (" EL NUMERO  MENOR ES") + b );
                    }
}
        }
    }
}
