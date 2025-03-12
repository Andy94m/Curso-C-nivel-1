using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int prom=0, acu=0, n, con;

            /*
            //carga 10 equipos de 10 personas
            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                    acu += n;
                }
                prom = acu / 20;
                Console.WriteLine("El promedio es: " + prom);
            }*/

            //carga 10 equipos de n personas
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese la edad: ");
                n = int.Parse(Console.ReadLine());
                acu = 0;
                con = 0;
                while(n != 0){
                    acu += n;
                    con++;
                    Console.WriteLine("Ingrese la edad: ");
                    n = int.Parse(Console.ReadLine());
                }
                prom = acu / con;
                Console.WriteLine("El promedio es: " + prom);
            }

            //se puede probar car de n equipos con n personas (while con while)
        }
    }
}
