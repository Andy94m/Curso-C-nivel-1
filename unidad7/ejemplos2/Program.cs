using System;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char[] nombre = new char[11];

            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese su nombre letra por letra... (termina con punto)");
            letra = char.Parse(Console.ReadLine());
            
            while(letra != '.' && indice < 10)
            {
                nombre[indice] = letra;
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            nombre[indice] = '\0';

            Console.Write("Hola ");
            indice = 0;
            while(nombre[indice] != '\0')
            {
                Console.Write(nombre[indice]);
                indice++;
            }*/

            string nombre;
            Console.WriteLine("Ingrese su nombre... ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            
        }
    }
}
