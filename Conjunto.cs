using PracticaN1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Conjunto : Coleccionable, Iterable
    {
        private List<Comparable> elementos;
        public Conjunto()
        {
            elementos = new List<Comparable>();
        }
        public List<Comparable> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
        public int Cuantos()
        {
            return elementos.Count;
        }
        public Comparable Maximo()
        {
            //if (Cuantos() == 0) return null;
            Comparable max = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if(elem.sosMayor(max))
                    max = elem;
            }
            return max;
        }
        public Comparable Minimo()
        {
            //if (Cuantos() == 0) return null;
            Comparable min = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMenor(min))
                    min = elem;
            }
            return min;
        }
        public void Agregar(Comparable c)
        {
            if(!this.Contiene(c))
                elementos.Add(c);
        }
        public bool Contiene(Comparable c)
        {
            foreach (Comparable e in elementos)
            {
                if(e.sosIgual(c))
                    return true;
            }
            return false;
        }
        public Iterador crearIterador()
        {
            return new IteradorDeLista(elementos);
        }
    }
}
