using System;

namespace ProgramacionSecuencial{
    class EntradaYSalidaPorConsola{
        /*static*/ void Main(string[] args){

            string nombre = "Juan";

            // ENTRADA Y SALIDA DE DATOS POR CONSOLA

            // Entrada de datos por consola
            Console.Write("Ingresa tu nombre: "); // Entrada de datos por consola usando valores
            string nombreIngresado = Console.ReadLine();

            Console.Write("Ingresa tu edad: "); // Entrada de datos por consola usando variables
            int edadIngresada = Convert.ToInt32(Console.ReadLine());

            // Salida de datos por consola
            Console.WriteLine("Hola, mundo!"); // Salida de datos por consola de un valor String
            Console.WriteLine("Hola, " + nombre + "!"); // Salida de datos por consola usando variables
            Console.WriteLine("Hola, " + nombreIngresado + "!");
            Console.WriteLine("Tu edad es " + edadIngresada + ".");
            
        }
    }
}
