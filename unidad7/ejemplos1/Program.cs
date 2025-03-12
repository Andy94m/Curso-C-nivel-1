using System;

namespace ejemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //vectores
            int n;

            //declaracion de un vector o array, se debe especificar el tamaño del mismo
            //double[] temperaturas = new double[10];
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                //cargar valores al array
                Console.WriteLine("Ingrese el numero...");
                n = int.Parse(Console.ReadLine());
                numeros[i] = n;
            }

            int acu = 0;

            //usar valores y leer el vector
            for (int i = 0; i < 10; i++)
            {
                acu+= numeros[i];
                Console.WriteLine("El valor es: " + numeros[i]);
            }

            int prom = acu / 10;

            Console.WriteLine("Promedio ");

        }
    }
}
