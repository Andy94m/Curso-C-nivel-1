﻿using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
            sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
                CADENA FUENTE: “La mar estaba serena"
                CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
                CADENA RESULTADO: “Li mir estibi sereni" */

            /*
            char[] frase = new char[30];
            char letraAct;
            char letraNew;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingrese una frase letra por letra: ");
            letra = char.Parse(Console.ReadLine());
            while (letra != '0' && indice < 30)
            {
                frase[indice] = letra;
                letra = char.Parse(Console.ReadLine());

                indice++;
            }
            
            frase[indice] = '\0';
            Console.WriteLine("La frase entera es: ");
            indice = 0;
            
            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }

            Console.WriteLine("Ingrese letra a reemplazar: ");
            letraAct = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese letra nueva: ");
            letraNew = char.Parse(Console.ReadLine());
            
            indice = 0;
            while (frase[indice] != '\0')
            {
                if (frase[indice] == letraAct)
                    frase[indice] = letraNew;
            indice++;
            }

            Console.WriteLine("La frase nueva es: ");
            indice = 0;

            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            } */

            string frase;
            char letraActual;
            char letraNew;

            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Ingrese la letra actual: ");
            letraActual = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la letra nueva");
            letraNew = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNew);

            Console.WriteLine("La cadena nueva es: ");
            Console.WriteLine(frase);
        }
    }
}
