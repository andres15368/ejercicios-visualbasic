using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUEGO
{
    class numeros
    {
        private int[] numero;

        public numeros()
        {
            numero = new int[16];
            for (int i = 0; i < 8; i++)
            {
                numero[i] = i;
               numero[i + 8] = i;
            }
        }

        public int obtenernumero()
         {
        Random aleatorio = new Random();
        int numeroAleatorio = aleatorio.Next(0, numero.Length);
            int aux = numero[numeroAleatorio];
            List<int> lista = numero.OfType<int>().ToList<int>();
            lista.RemoveAt(numeroAleatorio);
            numero = lista.ToArray();
            return aux;

        }


    }
}