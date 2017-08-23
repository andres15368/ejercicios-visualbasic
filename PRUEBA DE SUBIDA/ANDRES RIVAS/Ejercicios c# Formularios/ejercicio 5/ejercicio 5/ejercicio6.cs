using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class ejercicio6 : Form
    {
        public ejercicio6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for (int i=1; i<100; i++ )
            {
                i = i + 1;
                MessageBox.Show("el numero es; " + i);

                suma = suma + i;
            }
            MessageBox.Show("la sumatoria es:  " + suma);
        }
    }
}
