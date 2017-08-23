using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_1
{
    public partial class EJERCICIO1 : Form
    {
        public EJERCICIO1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operador1;
            int operador2;
            int resultado;

            operador1 = int.Parse(txtoperador1.Text);
            operador2 = int.Parse(txtoperador2.Text);

            resultado = operador1 + operador2;

            txtresultado.Text = resultado.ToString();
        }
    }
}
