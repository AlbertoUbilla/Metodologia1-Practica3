using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class LectorDeDatos
    {
        public int numeroPorTeclado()
        {
            Console.WriteLine("Ingrese un numero entero: ");
            return int.Parse(Console.ReadLine());
        }
        public string stringPorTeclado()
        {
            Console.WriteLine("Ingrese un texto: ");
            return Console.ReadLine();
        }
    }
}
