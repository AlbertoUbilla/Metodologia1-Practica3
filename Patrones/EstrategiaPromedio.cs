using PracticaN1.Patrones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class EstrategiaPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio() == ((Alumno)b).getPromedio();
        }
        public bool sosMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio() < ((Alumno)b).getPromedio();
        }
        public bool sosMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getPromedio() > ((Alumno)b).getPromedio();
        }
    }
}
