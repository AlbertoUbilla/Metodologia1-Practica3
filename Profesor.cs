using PracticaN1.Interfaces;
using PracticaN1.Patrones;
using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Profesor : Persona, Observado
    {
        private List<Observador> observadores;
        private bool hablando;

        private int antiguedad;
        private EstrategiaDeComparacion estrategia;
        
        //public Profesor() { }
        public Profesor(string n, int d, int a) : base (n, d)
        {
            this.antiguedad = d;
            this.observadores = new List<Observador> ();
        }
        public int getAntiguedad()
        {
            return this.antiguedad;
        }
        public void hablarAlaClase()
        {
            Console.WriteLine("Hablando de algun tema.");
            hablando = true;
            notificar();
        }
        public void escribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarron");
            hablando= false;
            notificar();
        }
        public bool estaHablando()
        {
            return this.hablando;
        }
        public void agregarObservador(Observador o )
        {
            this.observadores.Add(o);
        }
        public void quitarObservador(Observador o)
        {
            this.observadores.Remove(o);
        }
        public void notificar()
        {
            foreach(var o in observadores)
            {
                o.actualizar(this);
            }
        }
        public void setEstrategia(EstrategiaDeComparacion e)
        {
            this.estrategia = e;
        }
        public override bool sosIgual(Comparable c)
        {
            return this.estrategia.sosIgual(this, (Profesor)c);
        }
        public override bool sosMenor(Comparable c)
        {
            return this.estrategia.sosMenor(this, (Profesor)c);
        }
        public override bool sosMayor(Comparable c)
        {
            return this.estrategia.sosMayor(this, (Profesor)c);
        }
        public override string ToString()
        {
            return $"Nombre: {getNombre()}, DNI: {getDni()}, Antiguedad: {antiguedad}";
        }
    }
}
