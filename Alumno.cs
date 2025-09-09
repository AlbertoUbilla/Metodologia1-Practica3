using PracticaN1.Interfaces;
using PracticaN1.Patrones;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Alumno : Persona, Observador
    {
        private int legajo;
        private double promedio;
        private EstrategiaDeComparacion estrategia;

        public Alumno()
        {
            estrategia = new EstrategiaPromedio();
        }
        public Alumno(int l, double p, string n, int d) : base(n,d)
        {
            this.legajo = l;
            this.promedio = p;
            estrategia = new EstrategiaPromedio();
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public double getPromedio()
        {
            return this.promedio;
        }
        public void setEstrategia(EstrategiaDeComparacion e)
        {
            estrategia = e;
        }
        public override bool sosIgual(Comparable c)
        {
            return estrategia.sosIgual(this, c);
        }
        public override bool sosMenor(Comparable c)
        {
            return estrategia.sosMenor(this, c);
        }
        public override bool sosMayor(Comparable c)
        {
            return estrategia.sosMayor(this, c);
        }
        public override string ToString()
        {
            return $"Nombre: {getNombre()}, DNI: {getDni()}, Legajo: {legajo}, Promedio: {promedio}";
        }
        public void prestarAtencion()
        {
            Console.WriteLine("Prestando Atencion.");
        }
        public void distraerse()
        {
            Random random = new Random();
            string[] frases = new string[] {"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
            Console.WriteLine(frases[random.Next(0, 2)]);        
        }
        public void actualizar(Observado o)
        {
            if (((Profesor)o).estaHablando())
            {
                    this.prestarAtencion();
            }
            else
                this.distraerse();
        }
    }
}
