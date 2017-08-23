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
    public partial class ejercicio_7 : Form
    {
        public ejercicio_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int suma = 0;
            for (int i=1; i<300; i++)
            {
                if (i % 2 == 1)
                {

                    MessageBox.Show("los numeros impares son:  " + i);
                }
                suma = 300/2;
            }
            
            MessageBox.Show(" hay " + suma+ " numeros impares");
        }
    }
}
