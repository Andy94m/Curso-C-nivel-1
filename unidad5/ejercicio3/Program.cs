using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad=0, acum=0, cont=0, prom;

            Console.WriteLine("Ingrese 20 edades: ");

            for (int i = 0; i < 21; i++)
            {
                edad = int.Parse(Console.ReadLine());

                if(edad >= 18){
                    acum += edad;
                    cont++;
                }
            }

            prom = acum / cont;

            Console.WriteLine("El promedio de edad mayores a 18 años es de: " + prom);
        }
    }
}
