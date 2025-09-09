using PracticaN1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class IteradorDeLista : Iterador
    {
        private List<Comparable> lista;
        private int indice;

        public IteradorDeLista(List<Comparable> l)
        {
            lista = l;
            indice = 0;
        }
        public void primero()             //Para posicionarse al principio de la colección
        {
            indice = 0;
        }

        public void siguiente()           //Para ir al elemento siguiente
        {
            indice++;
        }

        public bool fin()               //Para saber si se llegó al final de la colección 
        {
            return indice == lista.Count;
        }

        public Comparable actual()       //Para obtener el elemento actual
        {
            return lista[indice];
        }
    }
}
