using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar por teclado un número y luego
            // devolver su valor elevado al cubo.

            int num, cubo;

            Console.WriteLine("Ingrese un numero: ");

            num = int.Parse(Console.ReadLine());

            cubo = num * num * num;

            Console.WriteLine("Su numero elevado al cubo es: " + cubo);
        }
    }
}
