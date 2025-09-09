using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class GeneradorDeDatosAleatorios
    {
        Random rand = new Random();
        public int numeroAleatorio(int max)
        {
            return this.rand.Next(0,max);
        }
        public string stringAleatorio(int cant)
        {
            const string cadena = "qwertyuiopasdfghjklñzxcvbnm";
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < cant; i++)
            {
                int index = rand.Next(0,cadena.Length);
                str.Append(cadena[index]);
            }
            return str.ToString();
        }
    }
}
