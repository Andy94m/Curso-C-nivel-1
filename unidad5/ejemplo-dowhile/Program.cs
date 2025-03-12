using System;

namespace ejemplo_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            do{
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());
                con++;
            }while(n != 0);

            Console.WriteLine("Ingresaste " + con + " nros.");
        }
    }
}
