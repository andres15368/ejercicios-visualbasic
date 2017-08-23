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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  suma=0;

            for (int i =1; i<100; i++)
            {
                
                i = i + 4;
                MessageBox.Show("la  numero  " + i);
                suma = suma + i;
            }

            
            MessageBox.Show("la sumatoria es;  " + suma);
            




        }
    }
}
