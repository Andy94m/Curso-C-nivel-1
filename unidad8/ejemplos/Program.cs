using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            num = devolverNum();

            Console.WriteLine("Fin del programa: " + devolverNum());

            Console.WriteLine(num);
        }

        static int devolverNum(){
            int nro = 22;
            return nro;
        }
    }
}
