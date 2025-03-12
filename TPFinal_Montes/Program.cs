using System;

namespace TPFinal_Montes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("iNGRESE n2: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b));
            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref b)); 
            Console.WriteLine("El resultado es: " + haceAlgo2(ref a, ref a)); 
        }

        static int haceAlgo2(ref int numero, ref int numero2){
            int res;
            numero = numero * 2;
            numero2 = numero2 * 3;

            res = numero * numero2;

            return res;
        }
    }
}
