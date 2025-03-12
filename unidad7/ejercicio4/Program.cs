using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            - Número de Artículo (1 a 15)
            - Cantidad Vendida 

            Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            Se pide determinar e informar:
            a) El número de artículo que más se vendió en total.
            b) Los números de artículos que no registraron ventas.
            c) Cuantas unidades se vendieron del número de artículo 10. */

            int[] art = new int[15];
            int[] cant = new int[50];
            int numArt = 1, cantSell, indice = 0, sellMax = 0, artMax=0;

            //carga valor de articulos
            for (int i = 0; i < 15; i++)
            {
                art[i] = i+1;
                cant[i] = 0;
                Console.Write(art[i]);
                Console.Write(cant[i]);
            }
            Console.WriteLine("\n");

            //carga cantidad ventas
            while (numArt != 0)
            {
                Console.WriteLine("Ingrese el numero de articulo de su venta: ");
                numArt = int.Parse(Console.ReadLine());
                
                if (numArt != 0)
                {
                    indice = numArt - 1;
                    art[indice] = numArt;

                    Console.WriteLine("Ingrese la cantidad vendida: ");
                    cantSell = int.Parse(Console.ReadLine());

                    if(cantSell != 0)
                    {
                        cant[indice] += cantSell;

                    }
                }else
                {
                    numArt = 0;
                }

            }
            
            //busqueda maximos
            for (int i = 0; i < 15; i++)
            {
                //Console.WriteLine("Articulo " + art[i]);
                //Console.WriteLine("Cantidad " + cant[i]);
                //Console.WriteLine("----------------------");

                if(cant[i] > sellMax ){
                    sellMax = cant[i];
                    artMax = art[i];
                }
            }

            //busqueda sin venta
            for (int i = 0; i < 15; i++)
            {
                if (cant[i] == 0)
                {
                    Console.WriteLine("Sin venta - art " + art[i]);
                }
            }

            //impresion
            Console.WriteLine("Articulo mas vendido: " + artMax);
            Console.WriteLine("Cantidad " + sellMax);
            Console.WriteLine("----------------------");
            Console.WriteLine("Articulo nro " + art[9] + " ventas " + art[9]);
            
        }
    }
}