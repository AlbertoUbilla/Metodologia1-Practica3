using PracticaN1.Interfaces;
using PracticaN1.Patrones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Helper
    {
        public static void Llenar(Coleccionable c, int opcion)
        {
            //Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                c.Agregar(FabricaDeComparables.crearAleatorio(opcion));
            }
        }
        public static void Informar(Coleccionable c, int opcion)
        {
            Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
            Console.WriteLine("Elemento Maximo: " + c.Maximo());
            Console.WriteLine("Elemento Minimo: " + c.Minimo());

            Comparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
            if (c.Contiene(comparable))
                Console.WriteLine("El elemento leido esta en la coleccion.");
            else
                Console.WriteLine("El elemento leido no esta en la coleccion.");
        }
        public static void LlenarAlumnos(Coleccionable c)
        {
            Random random = new Random();
            string[] nombres = { "Ana", "Luis", "Carlos", "Marta", "Pedro", "Sofia", "Juan", "Maria", "Ramona", "Jose", "Claudio" };
            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int dni = random.Next(10000000, 99999999);
                int legajo = random.Next(1000, 9999);
                double promedio = random.NextDouble() * 10;
                c.Agregar(new Alumno(legajo, promedio, nombre, dni));
            }
        }
        public static void imprimirElementos(Iterable c)
        {
            Iterador iterador = c.crearIterador();
            iterador.primero();                             
            while (!iterador.fin())                         
            {
                Comparable elemento = iterador.actual();    
                Console.WriteLine(elemento);

                iterador.siguiente();                       
            }
        }
        public static void cambiarEstrategiaDeAlumnos(Iterable i, EstrategiaDeComparacion e)
        {
            Iterador iterador = i.crearIterador();
            iterador.primero();
            while (!iterador.fin())
            {
                Comparable elemento = iterador.actual();
                //((Alumno)elemento).setEstrategia(estrategia);          //se cambia la estrategia
                ((Alumno)elemento).setEstrategia(e);

                iterador.siguiente();
            }
        }
        public static void InformarAlumnos(Coleccionable c)
        {
            Random random = new Random();
            //se pide ingresar los datos de un alumno
            Console.Write("Ingrese un nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese un DNI: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un legajo: ");
            int legajo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un promedio (1-10): ");
            int promedio = int.Parse(Console.ReadLine());

            Comparable c2 = new Alumno(legajo, promedio, nombre, dni);         //se crea el alumno

            if (c.Contiene(c2))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");

            Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
            Console.WriteLine("Elemento mas chico: " + c.Minimo());
            Console.WriteLine("Elemento mas grande: " + c.Maximo());
        }
        public static void dictadoDeClases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {
                p.hablarAlaClase();
                p.escribirEnElPizarron();
            }
        }
    }
}
