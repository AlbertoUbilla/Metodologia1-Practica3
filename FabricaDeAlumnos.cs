using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        LectorDeDatos lector = new LectorDeDatos();

        public override Comparable crearAleatorio()
        {
            return new Alumno(generador.numeroAleatorio(99999),generador.numeroAleatorio(99999),generador.stringAleatorio(99999),generador.numeroAleatorio(99999));
        }

        public override Comparable crearPorTeclado()
        {
           return new Alumno(lector.numeroPorTeclado(), lector.numeroPorTeclado(), lector.stringPorTeclado(),lector.numeroPorTeclado());
        }
    }
}
