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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "(INGLES)";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "(RUSO)";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "(ITALIANO)";
            }
        }
        }
}
