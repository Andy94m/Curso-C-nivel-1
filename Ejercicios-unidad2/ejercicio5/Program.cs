using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
            y luego calcule y emita por pantalla el promedio final */

            float n1, n2, n3, prom;

            Console.WriteLine("Ingrese 3 notas para calcular su promedio. \n NOTA #1: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("NOTA #2: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("NOTA #3: ");
            n3 = float.Parse(Console.ReadLine());

            prom = (n1 + n2 + n3) / 3;

            Console.WriteLine("Su promedio es: "+ prom);

        }
    }
}
