using PracticaN1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Pila : Coleccionable, Iterable
    {
        private List<Comparable> elementos;
        public Pila()
        {
            elementos = new List<Comparable>();
        }
        public List<Comparable> Elementos
        {
            get { return elementos; }
            set { elementos = value; }
        }
        public void apilar(Comparable c)
        {
            elementos.Add(c);
        }
        public Comparable desapilar()
        {
            Comparable e = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
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
            this.apilar(c);
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
