using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Numero : Comparable
    {
        private int valor;
        
        public Numero(int v)
        {
            this.valor = v;
        }
        public int getValor()
        {
            return this.valor;
        }
        public bool sosIgual(Comparable c)
        {
            Numero num = (Numero)c;
            return this.valor == num.getValor();
        }
        public bool sosMenor(Comparable c)
        {
            Numero num = (Numero)c;
            return this.valor < num.getValor();
        }
        public bool sosMayor(Comparable c)
        {
            Numero num = (Numero)c;
            return this.valor > num.getValor();
        }
        public override string ToString()
        {
            return this.valor.ToString();
        }
    }
}
