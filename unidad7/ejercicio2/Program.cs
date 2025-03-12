using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] num = new int[10];
            int sum = 0, prom = 0, n = 0;
    
            Console.WriteLine("Ingrese sus numeros para promediar: ");
            
            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                num[i] = n;
                sum += num[i];
            }

            prom = sum / 10;

            Console.WriteLine("Promedio: " + prom);
            for (int j = 0; j < 10; j++)
            {
                if(num[j] > prom)
                    Console.WriteLine("Este valor es mayor al promedio: " + num[j]);
            }
        }
    }
}
