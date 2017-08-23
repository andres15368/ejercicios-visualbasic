using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRASES_PALINDROMAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FRASE1 = "", FRASE2 = "";
            string le = "";
            int i = 0, tl = 0;

            FRASE1 = textBox1.Text;
            tl = FRASE1.Length;

            for (i = tl - 1; i >= 0; i--)
            {
                le = FRASE1.Substring(i, 1);
                FRASE2 = FRASE2 + le;
            }
            MessageBox.Show(" la palabra invertida es:  " + FRASE2);

            if (FRASE1.Equals(FRASE2))
            {
                MessageBox.Show("LA FRASE INVERTIDA INDICAN LO MISMO POR LO TANTO SON PALINDROMES");
            }
            else
                MessageBox.Show("lA FRASE INVERTIDA NO COINSIDE POR LO TANTO NO ES PALINDROMES");
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
