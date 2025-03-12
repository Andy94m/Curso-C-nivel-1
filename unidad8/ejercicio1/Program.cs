using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre 
            //por pantalla el monto total a pagar. Usar la función.

            int precio = 0, cantidad = 0, total = 0;

            Console.WriteLine("Precio: ");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            total = producto(precio, cantidad);

            Console.WriteLine("El monto total a pagar es: " + total);

        }

        static int producto(int num1,int num2){
            int producto;
            producto = num1 * num2;
            return producto;
        }
    }
}
