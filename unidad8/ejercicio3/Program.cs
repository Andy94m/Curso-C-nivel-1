using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            //Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo 
            //en cuenta sólo los números primos.

            int n, cont = 0, sum = 0, prom;
            bool esPrimo;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            //esPrimo = primo(n);


            while(n != 0){
                esPrimo = primo(n);

                if(esPrimo){
                    Console.WriteLine("Su numero es primo! ");
                    cont ++;
                    sum += n;
                }else
                    Console.WriteLine("Su numero NO ES primo! ");

            n = int.Parse(Console.ReadLine());
            }

            prom = sum / cont;
            Console.WriteLine("El promedio de nros primos es: " + prom);
        }

        static bool primo (int num){
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    sum ++;
            }

            if(sum == 2)
                return true;
            else
                return false;
        }
    }
}
