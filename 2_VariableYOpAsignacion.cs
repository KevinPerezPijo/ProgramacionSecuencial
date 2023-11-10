using System;

namespace ProgramacionSecuencial{
    class VariableYOpAsignacion{
        /*static*/ void Main(string[] args){
            // DECLARACION DE VARIABLES
            // Variables de Tipo Entero
            byte varByte = 255; // Variable byte
            sbyte varSbyte = -128; // Variable sbyte
            short varShort = -32768; // Variable short
            ushort varUshort = 65535; // Variable ushort
            int varInt = -2147483648; // Variable int
            uint varUint = 4294967295; // Variable uint
            long varLong = -9223372036854775808; // Variable long
            ulong varUlong = 18446744073709551615; // Variable ulong
            // Variables de tipo punto flotante
            float varFloat = 3.402823E+38F; // Variable float
            double varDouble = 1.79769313486232D; // Variable double
            decimal varDecimal = 79228162514264337593543950335M; // Variable decimal
            // Variables de tipo booleano
            bool varBool = true; // Variable booleana
            // Variables de tipo char o String
            char varChar = 'A'; // Variable char
            string varString = "Hola Mundo!"; // Variable string

            // ASIGNACION DE VALORES DE LAS VARIABLES

            // DECLARACIONES DE CONSTANTES

            // MOSTRANDO LOS VALORES DE LAS VARIABLES Y CONSTANTES
            Console.WriteLine("Variable byte: " + varByte);
            Console.WriteLine("Variable sbyte: " + varSbyte);
            Console.WriteLine("Variable short: " + varShort);
            Console.WriteLine("Variable ushort: " + varUshort);
            Console.WriteLine("Variable int: " + varInt);
            Console.WriteLine("Variable uint: " + varUint);
            Console.WriteLine("Variable long: " + varLong);
            Console.WriteLine("Variable ulong: " + varUlong);
            Console.WriteLine("Variable float: " + varFloat);
            Console.WriteLine("Variable double: " + varDouble);
            Console.WriteLine("Variable decimal: " + varDecimal);
            Console.WriteLine("Variable booleana: " + varBool);
            Console.WriteLine("Variable char: " + varChar);
            Console.WriteLine("Variable string: " + varString);
        }
    }
}
