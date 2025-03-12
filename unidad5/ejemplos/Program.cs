using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, promedio, suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la nota: ");
                n = int.Parse(Console.ReadLine());
                suma += n;
            }
            
            promedio = suma / 5;
            Console.WriteLine("El promedio de notas es: " + promedio);
        }
    }
}
