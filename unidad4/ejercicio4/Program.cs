using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos 
            primeros es mayor al producto del segundo con el tercero */

            int a, b, c, sum, prod;

            Console.WriteLine("Ingrese 3 numeros:");
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            sum = a + b;
            prod = b * c;

            if(sum > prod)
                Console.WriteLine("La suma de los primeros 2 numeros es mayor al producto de los ultimos 2 numeros ingresados.");


        }
    }
}
