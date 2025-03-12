using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que permita ingresar los kilómetros existentes 
            entre dos ciudades y la velocidad promedio de un vehículo. Calcular y 
            emitir por pantalla el tiempo aproximado que demandará llegar de un punto 
            a otro teniendo en cuenta los datos ingresados */

            float km, vel, hs;

            Console.WriteLine("Ingrese los km existentes entre la ciudada A y ciudad B: ");
            km = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad a la que viaja el auto");
            vel = float.Parse(Console.ReadLine());

            hs = km / vel;

            Console.WriteLine("Su vehiculo irá desde la ciudad A a la B en: " + hs.ToString("0.00") + "hs");
        }
    }
}
