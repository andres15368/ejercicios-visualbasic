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
namespace consultar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] NUMERO = new int[52];

        private void button1_Click(object sender, EventArgs e)
        {
            int resultado;
             {
                 resultado = promedio_num(10);
        }

         
    }

        public int promedio_num( int n)
             {
            string d1;

            int suma, prom, dada;
            int i;

            suma = 0;

            for (i =1; i<= 10; i++)
                 {
                d1 = Interaction.InputBox  (" ingrese numero", "numero", "", 10, 10);
                if (d1 =="")
                     {   

                    MessageBox.Show ("debe ingresar un valor, no puede dejar el campo vacio");
                    i = i-1;
    }
                else
     {
        dada = int.Parse(d1);
        NUMERO[i] = dada;
        suma = suma + NUMERO[i];
}
}

    prom = suma /10;
            MessageBox .Show ("el promedio es: " + prom);

            for (i =1; i<10; i++)
     {
                if (NUMERO[i] > prom)
                {
                
        MessageBox.Show ("se encuentra por encima del promedio" +  NUMERO[i]); 
    }
    }
    return n;
    }
    }
    }


