using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public abstract class FabricaDeComparables
    {
        public static Comparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica = new FabricaDeAlumnos(); break;
            }
            return fabrica.crearAleatorio();
        }
        public static Comparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = null;
            switch (opcion)
            {
                case 1: fabrica = new FabricaDeNumeros(); break;
                case 2: fabrica = new FabricaDeAlumnos(); break;
            }
            return fabrica.crearPorTeclado();
        }
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();
    }
}
