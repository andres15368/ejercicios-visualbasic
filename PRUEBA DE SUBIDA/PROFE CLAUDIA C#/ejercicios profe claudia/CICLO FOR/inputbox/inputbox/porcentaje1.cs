using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace inputbox
{
    public partial class porcentaje1 : Form
    {
        public porcentaje1()
        {
            InitializeComponent();
        }
        long reprobado;
        long porcentaje;
        string nota;
        long i = 1;

        private void button1_Click(object sender, EventArgs e)
        {


            while (i <=5)
            {
                nota = Interaction.InputBox("ingrese valor", "mensaje", "  ", 50, 50);
                if (Convert.ToDouble(nota) >= 0 && Convert.ToDouble(nota) <= 3.4)
                {
                    reprobado = reprobado + 1;


                } i = i + 1;

            }

                porcentaje = (reprobado * 100 )/5;

            
            MessageBox.Show("el porcentaje de estudiantes reprobado " + porcentaje + " % ");
        }
    }
}