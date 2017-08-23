using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOTON_FORMULARIO
{
    public partial class FORMULARIO : Form
    {
        public FORMULARIO()
        {
            InitializeComponent();
        }

        private void FORMULARIO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Text = Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Text = Text + button3.Text;
        }
   
    }
}
