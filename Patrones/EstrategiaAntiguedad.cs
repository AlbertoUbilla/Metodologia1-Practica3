using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1.Patrones
{
    public class EstrategiaAntiguedad : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable a, Comparable b)
        {
            return ((Profesor)a).getAntiguedad() == ((Profesor)b).getAntiguedad();
        }
        public bool sosMenor(Comparable a, Comparable b)
        {
            return ((Profesor)a).getAntiguedad() < ((Profesor)b).getAntiguedad();
        }
        public bool sosMayor(Comparable a, Comparable b)
        {
            return ((Profesor)a).getAntiguedad() > ((Profesor)b).getAntiguedad();
        }
    }
}
