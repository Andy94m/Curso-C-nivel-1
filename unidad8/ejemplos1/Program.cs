using System;

namespace ejemplos1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resultado;

            pedirDatos(ref n1, ref n2);

            //las variables se llaman ARGUMENTOS, pasaje por VALOR. 
            //Se obtiene el Return pero no se obtiene la modificación de la variable en la función
            //resultado = sumar(n1, n2);

            resultado = sumar(ref n1, n2);

            Console.WriteLine("El resultado es: " + resultado);
        }

        //Las variables se llaman PARAMETROS
        static int sumar(ref int a, int b){
            int r;
            r = a + b;
            return r;
        }

        static void pedirDatos(ref int j, ref int h){
            Console.WriteLine("Ingrese un nro: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro.. ");
            h = int.Parse(Console.ReadLine());
        }
    }
}
