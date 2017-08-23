using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlturaMayor
{
    public partial class Estatura : Form
    {
        public Estatura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           Double  a = Double.Parse(textBox1.Text);

                if (a <= 1.50)
                {

                    MessageBox.Show("La persona es de estatura baja");

                }

                if (a >= 1.51  && a< 1.70)
                {

                    MessageBox.Show("La persona es de estatura media: ") ;

                }

                if (a >= 1.71)
                {

                    MessageBox.Show("La persona es de estatura alta: ") ;

                }
            }
        }
    }
