using PracticaN1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Cola : Coleccionable, Iterable
    {
        private List<Comparable> elementos;

        // Constructor
        public Cola()
        {
            elementos = new List<Comparable>();
        }

        // Propiedades
        public List<Comparable> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
        public void Encolar(Comparable c)
        {
            elementos.Add(c);
        }

        public Comparable desencolar()
        {
            Comparable e = elementos[elementos.Count - 1];
            elementos.RemoveAt(0);
            return e;
        }
        public int Cuantos()
        {
            return elementos.Count;
        }

        public Comparable Minimo()
        {
            Comparable menor = elementos[0];
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMenor(menor))
                    menor = elemento;
            }

            return menor;
        }
        public Comparable Maximo()
        {
            Comparable mayor = elementos[0];
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMayor(mayor))
                    mayor = elemento;
            }

            return mayor;
        }

        public void Agregar(Comparable c)
        {
            this.Encolar(c);
        }
        public bool Contiene(Comparable c)
        {
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosIgual(c))
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
