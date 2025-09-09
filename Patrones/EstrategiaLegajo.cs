using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1.Patrones
{
    public class EstrategiaLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo() == ((Alumno)b).getLegajo();
        }
        public bool sosMenor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo() < ((Alumno)b).getLegajo();
        }
        public bool sosMayor(Comparable a, Comparable b)
        {
            return ((Alumno)a).getLegajo() > ((Alumno)b).getLegajo();
        }
    }
}
