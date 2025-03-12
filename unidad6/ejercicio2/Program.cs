using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

            -El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            -Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

            int num =-1, cont, contOrdenados=0, contImpar, maxImparGrup=0, max=0;
            double porcentaje, porcentajeMax=0;
            bool bandera;
            

            Console.WriteLine("Ingrese los numeros: ");

            for (int i = 0; i < 5; i++)
            {  
                Console.WriteLine("\ngrupo: " + (i+1));
                num = int.Parse(Console.ReadLine());

                max = num;
                contImpar=0;
                cont = 0;
                bandera = true;

                while(num != 0){
                    cont++;
                    if(num % 2 != 0){
                        contImpar++;
                    }                

                    num = int.Parse(Console.ReadLine());

                    if(num < max){
                        max = num;
                    }
                    else
                        bandera = false;

                }
                
                porcentaje = (double)(cont * contImpar) / 100; 

                if(porcentaje > porcentajeMax){
                    porcentajeMax = porcentaje;
                    maxImparGrup = i+1;
                }

                if(bandera){
                    contOrdenados++;
                    //Console.WriteLine("GRUPO ORDENADO " + contOrdenados);

                }

                /*
                Console.WriteLine("total numeros: " + cont);
                Console.WriteLine("impares: " + contImpar);
                Console.WriteLine("porcentaje impares: " + porcentaje);
                Console.WriteLine("porcentaje impares maximo: " + porcentajeMax); */

                Console.WriteLine("\n -------------------------------------" );
            }

            Console.WriteLine("El grupo con mas impares es: " + maxImparGrup);
            Console.WriteLine("Los grupos ordenados de mayor a menor son: " + contOrdenados);
        }
    }
}
