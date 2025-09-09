using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class ColeccionMultiple : Coleccionable
    {
        private Pila pila;
        private Cola cola;
        public ColeccionMultiple(Pila p, Cola c)
        {
            this.pila = p;
            this.cola = c;
        }
        public int Cuantos()
        {
            return pila.Cuantos() + cola.Cuantos();
        }
        public Comparable Maximo()
        {
            Comparable maxPila = pila.Maximo();
            Comparable maxCola = cola.Maximo();

            if (maxPila == null) return maxCola;
            if (maxCola == null) return maxPila;

            return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
        }
        public Comparable Minimo()
        {
            Comparable minPila = pila.Minimo();
            Comparable minCola = cola.Minimo();

            if (minPila == null) return minCola;
            if (minCola == null) return minPila;

            return minPila.sosMenor(minCola) ? minPila : minCola;
        }
        public void Agregar(Comparable c)
        {
            //No hace nada
        }
        public bool Contiene(Comparable c)
        {
            return pila.Contiene(c) || cola.Contiene(c);
        }
    }
}
