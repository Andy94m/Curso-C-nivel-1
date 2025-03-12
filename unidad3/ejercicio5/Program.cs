using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0, num1, num2, num3;

            Console.WriteLine("Ingrese 4 numeros");

            num0 = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            if(num0 >= 100)
                Console.WriteLine("El primer numero es mayor a 100: " + num0);

            if(num1 >= 100)
                Console.WriteLine("El segundo numero es mayor a 100: " + num1);

            if(num2 >= 100)
                Console.WriteLine("El tecer numero es mayor a 100: " + num2);
                
            if(num3 >= 100)
                Console.WriteLine("El cuarto numero es mayor a 100: " + num3);
                
        }
    }
}
