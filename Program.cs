using PracticaN1.Interfaces;
using PracticaN1.Patrones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear distintos coleccionables de alumnos
            //Pila pila = new Pila();
            //Cola cola = new Cola();
            //Conjunto conjunto = new Conjunto();

            //Agregar alumnos a los coleccionables
            //Helper.LlenarAlumnos(pila);
            //Helper.LlenarAlumnos(cola);
            //Helper.LlenarAlumnos(conjunto);
            
            //Helper.Llenar(pila, 1);

            //Imprimir los elementos de cada coleccionable
            //Console.WriteLine("Pila de alumnos");
            //Helper.imprimirElementos(pila);
            //Console.WriteLine();

            Profesor profe = new Profesor("Mauro", 123456, 4);
            Pila p = new Pila();
            Helper.Llenar(p, 2);
            Iterador ite = p.crearIterador();
            ite.primero();
            while (!ite.fin())
            {
                profe.agregarObservador((Observador)ite.actual());
                ite.siguiente();
            }
            Helper.dictadoDeClases(profe);



            /*Profesor profesor = new Profesor("Mauro", 1555445, 1554886);

            // Crear 20 alumnos y agregarlos como observadores
            for (int i = 1; i <= 20; i++)
            {
                Alumno alumno = new Alumno();
                profesor.agregarObservador(alumno);
            }
            Helper.dictadoDeClases(profesor);*/

            // Dictado de clases
            //Helper.dictadoDeClases(profesor);

            /*
            Console.WriteLine("Cola de alumnos");
            Helper.imprimirElementos(cola);
            Console.WriteLine();

            Console.WriteLine("Conjunto de alumnos");
            Helper.imprimirElementos(conjunto);
            Console.WriteLine();

            Console.WriteLine("Test de la función cambiarEstrategiaDeAlumnos");
            Console.WriteLine();

            EstrategiaDeComparacion estLegajo = new EstrategiaLegajo();
            EstrategiaDeComparacion estPromedio = new EstrategiaPromedio();
            */

            /*
            Iterable iterador = pila;         //se inicializa con pila por defecto
            Coleccionable c = pila;    // se inicializa con pila por defecto
            string op = "";
            while (op != "5")
            {
                Console.WriteLine("Coleccionable a Testear");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1_Pila");
                Console.WriteLine("2_Cola");
                Console.WriteLine("3_Conjunto");
                Console.WriteLine("4_Salir del programa");
                Console.WriteLine("-----------------------");
                Console.Write("Elija una opción (1-4): ");
                Console.WriteLine();
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        {
                            iterador = pila;
                            c = pila;
                            Console.WriteLine("Coleccionable: Pila");
                            break;
                        }
                    case "2":
                        {
                            iterador = cola;
                            c = cola;
                            Console.WriteLine("Coleccionable: Cola");
                            break;
                        }
                    case "3":
                        {
                            iterador = conjunto;
                            c = conjunto;
                            Console.WriteLine("Coleccionable: Conjunto");
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("sale del sistema");
                            Environment.Exit(0);
                            break;

                        }
                }

                Console.WriteLine("Estrategia por legajo");
                Helper.cambiarEstrategiaDeAlumnos(iterador, estLegajo);
                Helper.InformarAlumnos(c);
                Console.WriteLine();

                Console.WriteLine("Estrategia por promedio");
                Helper.cambiarEstrategiaDeAlumnos(iterador, estPromedio);
                Helper.InformarAlumnos(c);
                Console.WriteLine();
            }*/
        }
    }
}
