using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se 
            //debe emitir UN valor por pantalla.

            int num, max=0;

            Console.WriteLine("Ingrese 10 nros: ");

            for (int i = 1; i < 11; i++){
                num = int.Parse(Console.ReadLine());
                
                if(i == 0)
                    max = num;
                else{
                    if(num > max)
                        max = num;
                }
            }

            Console.WriteLine("El numero mayor es: " + max);
        }
    }
}
