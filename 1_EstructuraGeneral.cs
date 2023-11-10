// ESTRUCTURA GENERAL DE UN PROGRAMA EN C# 
/* Para crear un proyecto por consola se debe colocar los siguientes comandos en el cmd:
    dotnet new console -o NombreDeMiProyecto
*/
/* Para inicializar el programa se debe colocar los siguientes comandos en la terminal del proyecto:
    dotnet restore
    dotnet run
*/
// Esta línea importa el espacio de nombres System, que contiene las clases fundamentales del .NET Framework
using System;
// Este es el espacio de nombres que contiene el programa. El nombre del espacio de nombres puede ser cualquier cosa que desees
namespace ProgramacionSecuencial{
    // Esta es la clase principal del programa. El nombre de la clase también puede ser cualquier cosa que desees
    class EstructuraGeneral{
        // Este es el punto de entrada del programa. Es el método que se ejecuta cuando se inicia el programa. El método toma un argumento de matriz de cadenas llamado args, que contiene los argumentos de línea de comandos pasados al programa.
        /*static*/ void Main(string[] args){
            Console.WriteLine("Hola Mundo!"); // eSCRIBIENDO “Hola Mundo!” en la consola
        }
    }
}
