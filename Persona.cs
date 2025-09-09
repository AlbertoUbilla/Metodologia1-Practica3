using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public abstract class Persona : Comparable
    {
        private string nombre;
        private int dni;
        public Persona() { }
        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public int getDni()
        {
            return this.dni;
        }
        public virtual bool sosIgual(Comparable c)
        {
            Persona p = (Persona)c;
            return this.dni == p.getDni();
        }
        public virtual bool sosMenor(Comparable c)
        {
            Persona p = (Persona)c;
            return this.dni < p.getDni();
        }
        public virtual bool sosMayor(Comparable c)
        {
            Persona p = (Persona)c;
            return this.dni > p.getDni();
        }
        public override string ToString()
        {
            return $"Nombre: {nombre}, DNI: {dni}";
        }

        // Los metodos de comparales los tuve que declarar virtual
        // para poder usar override en la calse alumno y pode sobreescribir el metodo
    }
}
