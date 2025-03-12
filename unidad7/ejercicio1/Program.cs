using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector

            int[] num = new int[10];
            int n = 0, max=0, pos=0;

            Console.WriteLine("Ingrese 10 numeros: ");

            for (int i = 0; i < 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                num[i] = n;
            }
            
            max = num[0];
            
            for (int j = 0; j < 10; j++)
            {
                //Console.WriteLine("Posición: " + (j+1) + " valor: " + num[j]);

                if(num[j] > max)
                {
                    max = num[j];
                    pos = j + 1;
                }
                
            }

            Console.WriteLine("\nMAX posición: " + (pos+1) + " MAYOR " + max);
        }
    }
}
