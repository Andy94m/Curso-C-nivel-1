using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada 
            según los siguientes valores:

            Si el importe es menor a ARS 1000, no hay descuento.
            Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            
            Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe
            final con el descuento que corresponda.*/

            float compra;

            Console.WriteLine("Ingrese el monto de su compra: ");
            compra = float.Parse(Console.ReadLine());

            if(compra >= 1000){
                if(compra >= 5000)
                {
                    compra = compra * 0.82f;
                    Console.WriteLine("Tiene descuento del 18%!!!");
                }
                else
                {
                    compra = compra * 0.90f;
                    Console.WriteLine("Tiene descuento del 10%!!!");
                }
            }
            
            Console.WriteLine("Su total a pagar es de: " + compra);
                
        }
    }
}
