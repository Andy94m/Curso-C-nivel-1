using System;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar dos números y luego calcule y emita 
            //la suma en pantalla.

            int num1, num2, total;

            Console.WriteLine("Ingrese el primer nro:");
            num1= int.Parse(Console.Readline());

            Console.WriteLine("Ingrese el segundo nro:");
            num2= int.Parse(Console.Readline());


            total = num1 + num2;

            Console.WriteLine("La suma de ambos nros es: " + total);
        }
    }
}
