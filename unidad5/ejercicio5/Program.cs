using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo 
            //de los números pares y el mínimo de los números impares.

            int num, max=0, min=0;
            bool banPar = false, banImpar = false;

            Console.WriteLine("Ingrese 20 numeros: ");

            for (int i = 0; i < 20; i++)
            {
                num = int.Parse(Console.ReadLine());
                
                if(num % 2 == 0){
                    if(banPar == false){
                        max = num;
                        banPar = true;
                    }
                    else if(num > max)
                        max = num;
                }else
                    if(banImpar == false){
                        min = num;
                        banImpar = true;
                    }
            }
            Console.WriteLine("El mayor numero par fue: " + max);
            Console.WriteLine("El menor numero impar fue: " + min);        
        }
    }
}
