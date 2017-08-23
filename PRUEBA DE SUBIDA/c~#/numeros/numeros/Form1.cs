using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             double  suma, cant, valor, promedio;

            suma = 0; // contadores
            cant = 0; // contadores


            do 
 {
Console.WriteLine ("ingrese un valor (0 para finalizar):" );
                valor = int.Parse(Console.ReadLine ());

                if(valor !=0)
 {
                suma = suma + valor;
                    cant++;
        }

    }
            while (valor!= 0);
            
            if (cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine ("el valor de los valores ingresados es :");
                Console.WriteLine (" "  + promedio );

            }
            else
{
                Console.WriteLine ("no se ingresaron  valores");
}
            Console.ReadLine();
         
}
 }
}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cant != 0)
            {
                promedio = suma / cant;
                Console.WriteLine("el valor de los valores ingresados es :");
                Console.WriteLine(" " + promedio);

            }
            else
            {
                Console.WriteLine("no se ingresaron  valores");
            }
            Console.ReadLine();
         
        }
    }
}
