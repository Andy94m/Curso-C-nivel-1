using System;

namespace ejemplos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //corte de control
            
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            //cod: 1 river - 2 boca - 3 racing

            Console.WriteLine("Ingrese el legajo");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el codigo de Equipo");
            codigoEquipo = int.Parse(Console.ReadLine());

            while(sueldo > 0){
                //confirma si es el equipo actual para controlar el flujo, caso contrario sale del programa
                equipoActual = codigoEquipo;
                
                while(codigoEquipo == equipoActual){
                    Console.WriteLine("Ingrese el legajo");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el codigo de Equipo");
                    codigoEquipo = int.Parse(Console.ReadLine());
                }
            }

        }
    }
}
