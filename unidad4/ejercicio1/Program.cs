using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente*/


            int a, b, resultado;

            Console.WriteLine("Ingrese dos numeros a operar: ");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if(a > b){
                resultado = a - b;
                Console.WriteLine("Se realizó una resta, el resultado es: " + resultado);
            }
            else if(a == b){
                resultado = a + b;
                Console.WriteLine("Se realizó una suma, el resultado es: " + resultado);
            }
            else{
                resultado = a * b;
                Console.WriteLine("Se realizó un producto, el resultado es: " + resultado);
            }

        }
    }
}
