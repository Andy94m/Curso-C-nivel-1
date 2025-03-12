using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int num, cont=0, cantidad=0;
            bool primo = false;

            Console.WriteLine("Ingrese 10 numeros: ");

            for (int i = 0; i < 10; i++)
            {
                num = int.Parse(Console.ReadLine());

                for (int j = 1; j <= num; j++)
                {
                    if(num % j == 0)
                    {
                        cont++;
                        
                    }
                }
                if(cont == 2)
                    cantidad++; 
                cont = 0;
            }
            Console.WriteLine("Se encontraron " + cantidad + " numeros primos");
        }
    }
}
