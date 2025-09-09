using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1.Patrones
{
    public class EstrategiaDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni() == ((Alumno)b).getDni();
        }
        public bool sosMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni() < ((Alumno)b).getDni();
        }
        public bool sosMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getDni() > ((Alumno)b).getDni();
        }
    }
}
