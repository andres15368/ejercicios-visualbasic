﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idiomas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = "";
            if (checkBox1.Checked == true)
            {
                Text = Text + "Inglés";
            }
            if (checkBox2.Checked == true)
            {
                Text = Text + "Francés";
            }
            if (checkBox3.Checked == true)
            {
                Text = Text + "Alemán";
            }
        }
    }
}
