using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego 
            //mostrar por pantalla el menor de ellos.


            int num0, num1, num2, num3, menor, menor1;

            Console.WriteLine("Ingrese 4 numeros distintos: ");

            num0 = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if(num0 < num1)
                menor = num0;
            else
                menor = num1;

            if(num2 < num3)
                menor1 = num2;
            else
                menor1 = num3;

            if(menor < menor1)
                Console.WriteLine("El numero mas chico es: " + menor);
            else
                Console.WriteLine("El numero mas chico es: " + menor1);
        }
    }
}
