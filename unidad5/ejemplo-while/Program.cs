﻿using System;

namespace ejemplo_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;

            Console.WriteLine("Ingrese un nro: ");
            n = int.Parse(Console.ReadLine());

            while(n != 0){
                con++;
                Console.WriteLine("Ingrse un nro: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ingresaste: " + con + " nros.");
        }
    }
}
