using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más
            una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para
            ingresar el total facturado por un empleado y que luego calcule y emita por
            pantalla el sueldo total a cobrar por el mismo.*/

            float totalFacturado, comision, final;

            const float porcentaje = 0.05f, basico = 15000;

            Console.WriteLine("Ingrese el monto TOTAL facturado: ");
            totalFacturado = float.Parse(Console.ReadLine());
            
            //comi = (totalFacturado * 5) / 100;
            //0.05 es un double. f <- para formatear la variable
            comision = totalFacturado * porcentaje;
            final = basico + comision;

            Console.WriteLine("El monto FINAL a cobrar es: $" + final);                

        }
    }
}
