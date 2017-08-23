using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// una persona  debe realizar  un muestreo con 50 personas para determinar el promedio de peso de los niños 
//jovenes adultos y viejos  que existen en una zona habitacional se determina lascategorias con base ala 
//siguiente tabla 
//categoria deniños de 0 - 12 años
//categoria jovenes de 13-29 años
//categoria adultos de 30-59 años 
//viejos 60 en adelante 
namespace ciclo_for
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        { 
         

           



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new  promedio());
        }
    }
}
