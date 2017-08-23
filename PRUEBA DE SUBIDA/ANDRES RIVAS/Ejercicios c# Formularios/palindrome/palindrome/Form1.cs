using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a;
            string b;
            string c;

            a = Convert.ToString(textBox1.Text);
            b = "";
            c = "";


            for (int i=a.Length-1; i >=0;i--)
            {
                if (a.Substring(i,1) !=" ")
                {
                    b = b + a.Substring(i, 1);
                }

            }

            for (int i=0;i < a.Length;i ++)
            {
                if (a.Substring(i,1) !=" ")
                {
                    c = c + a.Substring(i, 1);
                }
            }
            textBox2.Text = b.ToString();

            MessageBox.Show(" " + b);

            if (c == b)
            {
                MessageBox.Show("Es una frase palíndroma.");
            }
            
            else

                MessageBox.Show("No es una frase palíndrome.");

            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
    }

