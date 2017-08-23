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


namespace trabajadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] nom;
        private void button1_Click(object sender, EventArgs e)
        {
               
            string nombre;
            string area;
            string sueldo;
            double r = 0;


            nom = new string[2];
 
            for (int i=1; i<=2; i++)
            {
                nombre = Interaction.InputBox("Ingrese su nombre:");
                area = Interaction.InputBox("Ingrese el area de trabajo:");
                sueldo = Interaction.InputBox("Digite sueldo: ");
                double n = Convert.ToDouble(sueldo);

                r = r + n;

                nom[i] = Convert.ToString(nombre);

                MessageBox.Show("nombre: " + nom[i]);

            }

           

            MessageBox.Show("Nomina total:  " + r);


        }


    }
}
