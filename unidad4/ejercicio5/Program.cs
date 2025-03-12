using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los
            //mismos se encuentran ordenados de forma decreciente.

            int a, b, c, d, min;

            Console.WriteLine("Ingrese 4 numeros: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d)
                Console.WriteLine("Los numeros estan ordenados de forma decreciente.");
            else
                Console.WriteLine("Los numeros no estan ordenados de forma decreciente");
            
        }
    }
}
