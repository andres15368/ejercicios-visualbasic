using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumatoria_de_5
{
    public partial class sumatoria_de_2 : Form
    {
        public sumatoria_de_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int suma = 0;

            for(int i=1; i<100;i++)
            {
                i = i + 1;
                MessageBox.Show(" El número es   :" +i );
                suma = suma + i;
            }
            MessageBox.Show("La sumatoria es   :" + suma);
        }
    }
}
