using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            Para ello existe la siguiente escala de precios:

                        i5 (1)	    i7 (2)	    i9 (3)
            8 RAM (1)	USD 800 	USD 900	    USD 1200
            16 RAM (2)	USD 900	    USD 1000	USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información y 
            que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300.
            Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si 
            extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita 
            por pantalla el monto de la máquina seleccionada.*/

            int micro, ram, disco, valor = 0;

            Console.WriteLine("Ingrese la opcion numerica para el procesador que desee: \n 1) i5 \n 2) i7 \n 3) i9");
            micro = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opcion numerica para la RAM que desee: \n 1) 8GB  \n 2) 16GB \n 3) 32GB");
            ram = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la opcion numerica para si desea o no disco 1TB que desee: \n 1) SI \n 2) NO");
            disco = int.Parse(Console.ReadLine());

            if(micro == 1){
                if(ram == 1)
                    valor = 800;
                else if(ram == 2)
                    valor = 900;
                else if(ram == 3)
                    valor = 1000;
            }
            else if(micro == 2){
                if(ram == 1)
                    valor = 900;
                else if(ram == 2)
                    valor = 1000;
                else if(ram == 3)
                    valor = 1400;
            }
            else if(micro == 3){
                if(ram == 1)
                    valor = 1200;
                else if(ram == 2)
                    valor = 1400;
                else if(ram == 3)
                    valor = 2000;
            }
            if(disco == 1)
                valor += 300;

            Console.WriteLine("El costo final de su equipo es: $" + valor);
            

        }
    }
}
