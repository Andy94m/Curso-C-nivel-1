using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad 
            de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros 
            vendidos y calcule y emita el importe con el descuento  aplicado.. */

            float lts, valor, total=0;

            Console.WriteLine("Ingrese el importe total de su compra: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los litros comprados: ");
            lts = float.Parse(Console.ReadLine());

            if(lts > 500)
                valor *= 0.75f;
            else if(lts > 300)
                valor *= 0.85f;
            else if(lts > 100)
                valor *= 0.90f;

            Console.WriteLine("El importe final a pagar es: $" + valor);
        
        } 
    }

}
