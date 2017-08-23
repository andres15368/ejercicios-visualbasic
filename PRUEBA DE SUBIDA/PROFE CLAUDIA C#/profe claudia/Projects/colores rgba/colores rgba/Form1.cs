﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colores_rgba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rojo = int.Parse(comboBox1.Text);
            int verde = int.Parse(comboBox2.Text);
            int azul = int.Parse(comboBox3.Text);

            BackColor = Color.FromArgb(rojo, verde, azul);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int f = 0; f <= 255; f++)
            {
                comboBox1.Items.Add(f.ToString());
                comboBox2.Items.Add(f.ToString());
                comboBox3.Items.Add(f.ToString());

            }
        }
    }
}
