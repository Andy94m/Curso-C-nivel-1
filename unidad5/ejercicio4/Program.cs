using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo 
            //o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo

            int num, con=0;

            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    con++;
            }

            if(con == 2)
                Console.WriteLine("Su numero es primo");   
            else
                Console.WriteLine("Su numero NO es primo"); 
        }
    }
}
 