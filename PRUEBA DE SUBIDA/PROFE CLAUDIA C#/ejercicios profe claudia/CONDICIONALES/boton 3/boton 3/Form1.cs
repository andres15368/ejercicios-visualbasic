﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boton_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Text.Length < 10)
            {
                Text = Text + button1.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Text.Length < 10)
            {
                Text = Text + button2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Text.Length < 10)
            {
                Text = Text + button3.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}