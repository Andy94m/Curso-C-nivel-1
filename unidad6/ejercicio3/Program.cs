using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int num, cont=0, contGrupo=0;

            Console.WriteLine("Ingrese listas de numeros: ");
            num = int.Parse(Console.ReadLine());

            while(num >= 0){
                Console.WriteLine("dentro del while1");
                contGrupo++;
                cont=0;
                
                while(num != 0){
                    Console.WriteLine("dentro del while2");
                    cont++;
                    num = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("El grupo nro " + contGrupo);
                Console.WriteLine("tiene cantidad de numeros " + cont);
                num=1;
            }
            
            Console.WriteLine("fin del programa");

        }
    }
}
