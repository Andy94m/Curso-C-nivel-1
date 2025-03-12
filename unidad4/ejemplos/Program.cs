using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND y OR ....... NOT
            // AND [y] Operador: &&
            // OR [o] Operador: ||
            // v OP v OR v OP v

            int edad = 20;
            char inicial= 'H';

            //  true    &&      true
            if(!(inicial == 'J' || inicial == 'H') && edad > 20){
                Console.WriteLine("21 OFF...");
            }
            Console.WriteLine("Fin del programa");

            //AND
            //true && true = true
            //false && true = false
            //true && false = false
            //false && falsa = false

            //OR
            //true || false = true
            //false || true = true
            //true || true = true
            //false || false = false

        }
    }
}
