using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            int n, con = 0;

            Console.WriteLine("Ingrese un numero");
            
            for (int i = 0; i < 5; i++)
            {
                n = int.Parse(Console.ReadLine());
                if(par(n))
                    con++;
            }
            Console.WriteLine("La cantidad de nros pares es: " + con);
        }
        static bool par(int numero){
            if(numero % 2 == 0){
                return true;
            }else
            {
                return false;
            }
        }
    }
}
