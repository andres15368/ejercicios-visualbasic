using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyect
{
    class numeros
    {
        private int[] num;
        private String[] rutas;

        public numeros()

        {
            num = new int[16];
            rutas = new String[8];

            for (int i = 0; i < 8; i++)
            {

                num[i] = i;
                num[i + 8] = i;
                rutas[i] = "./IMAGENES/" + i + ".jpg";
            }

        }
        public int obtenernumeros()
        {
            Random aleatorio = new Random();
            int numeroaleatorio = aleatorio.Next(0, num.Length);
            int aux = num[numeroaleatorio];
            List<int> lista = num.OfType<int>().ToList<int>();
            lista.RemoveAt(numeroaleatorio);
            num = lista.ToArray();
            return aux;
        }

        public String conseguirimagenes(int aux)
        {
            for (int i=0; i<8; i++)
            {
                if (i==aux)
                {
                    return rutas[i];
                }
            }
            return "";
        }
    }
}