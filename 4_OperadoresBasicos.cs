using System;

namespace ProgramacionSecuencial{
    class OperadoresBasicos{
        static void Main(string[] args){
            
            int a = 10, b = 5;
            int x = 5, y = 10;
            bool p = true, q = false;

            // OPERADORES BASICOS

            // Operadores aritméticos
            Console.WriteLine("a + b = " + (a + b)); // Suma
            Console.WriteLine("a - b = " + (a - b)); // Resta
            Console.WriteLine("a * b = " + (a * b)); // Multiplicación
            Console.WriteLine("a / b = " + (a / b)); // División entera
            Console.WriteLine("a % b = " + (a % b)); // Módulo

            // Operadores relacionales
            Console.WriteLine("x < y: " + (x < y));   // Menor que
            Console.WriteLine("x > y: " + (x > y));   // Mayor que
            Console.WriteLine("x <= y: " + (x <= y)); // Menor o igual que
            Console.WriteLine("x >= y: " + (x >= y)); // Mayor o igual que
            Console.WriteLine("x == y: " + (x == y)); // Igual a
            Console.WriteLine("x != y: " + (x != y)); // Diferente de

            // Operadores lógicos
            Console.WriteLine("p && q: " + (p && q)); // AND lógico
            Console.WriteLine("p || q: " + (p || q)); // OR lógico
            Console.WriteLine("!p: " + !p);           // NOT lógico

            // OPERADORES DE MANIPULACION DE BITS

            // Operadores de manupulacion de bits
            int num1 = 60;  /* 60 = 0011 1100 */
            int num2 = 13;  /* 13 = 0000 1101 */
            int result;

            result = num1 & num2;   /* 12 = 0000 1100 */
            Console.WriteLine("num1 & num2: " + result);

            result = num1 | num2;   /* 61 = 0011 1101 */
            Console.WriteLine("num1 | num2: " + result);

            result = num1 ^ num2;   /* 49 = 0011 0001 */
            Console.WriteLine("num1 ^ num2: " + result);

            result = ~num1;         /* -61 = 1100 0011 */
            Console.WriteLine("~num1: " + result);

            // Operadores de desplazamiento de bits
            result = num1 << 2;     /* 240 = 1111 0000 */
            Console.WriteLine("num1 << 2: " + result);

            result = num1 >> 2;     /* 15 = 0000 1111 */
            Console.WriteLine("num1 >> 2: " + result);
        }
    }
}
