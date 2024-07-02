using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Poo.TP5
{
    public class Practice
    {
        /*
         * 1) Hacer un programa para ingresar una lista de 10 números 
         * y luego informar cuantos de los números ingresados son primos.
         */

        public void ExerciseOne()
        {
            int input;
            int primos = 0;

            for (int i = 0; i < 10; i++) 
            {
                input = Int16.Parse(Console.ReadLine());

                if (IsPrime(input))
                { 
                    //Console.WriteLine("Es primo");
                    primos++;
                }
               // else
                 //   Console.WriteLine("No Es primo");
            }

            Console.WriteLine($"Se ingresaron {primos} numero primos");
        }

        public bool IsPrime(int number)
        {
            int counter = 0;

            for (int i = 1;i <= number;i++) 
            {
                if (number % i == 0) counter++;
            }

            return counter == 2;
        }

        /*
         2) Dada una lista de números compuesta por 10 grupos y cada grupo separado del
        siguiente por un cero, se pide determinar e informar:
        a) Para cada uno de los grupos el máximo de los números pares y el máximo de los
        números impares.
        b) Para cada uno de los grupos el porcentaje de números negativos y números positivos.
        c) Cuantos números positivos había en total entre los 10 grupos.
         */

        public void ExerciseTwo() 
        {
            int index = 0;
            int[] listado = new int[] 
            {
                -1 , -2,   0 ,
                4, 2 , 3, -4, 2 , 3, -4, 5, 0,
                9, 10, 12, 20, -45, -26, 0,
                9, 10, -12, -89,65,74,12,1,0,
                9, -10, 96, 45, 78,3, 12, 0,
                -26, -14, -13, 0
            };


            /* a) Para cada uno de los grupos el máximo de los números pares y el máximo de los
            números impares.*/

            int input, maxPar = 0, maxInPar = 0, neg = 0, pos = 0, inputCount =0 , totalPos = 0;
            bool firstPar = true;
            bool firstInPar = true;

            for (int i = 0; i < 6;i++) 
            {
                Console.WriteLine($"\n Inicio grupo {i+1}" );
                //break; // terminar bucle contexto
                //continue; // continuar/ ignorar instrucciones de contexto

                while(true)
                {
                    //input = Int16.Parse(Console.ReadLine());
                    input = listado.ElementAt(index++);
                    //looping = (input == 0) ? true: false;

                    if (input == 0) break;

                    //a
                    if (input % 2 == 0)
                    {
                        if (firstPar)
                        {
                            maxPar = input;
                            firstPar = false;
                        }

                        maxPar = (input > maxPar) ? input : maxPar; 
                    }
                    else
                    {
                        if (firstInPar)
                        {
                            maxInPar = input;
                            firstInPar = false;
                        }

                        maxInPar = (input > maxInPar) ? input : maxInPar;
                    }

                    //b
                    inputCount++;

                    if (input > 0)
                        pos++;
                    else
                        neg++;
                    //c
                    totalPos +=( input > 0 ) ? 1 : 0;
                }

                firstPar = true;
                firstInPar = true;

                Console.WriteLine($"Maximo Par: {maxPar}" );
                Console.WriteLine($"Maximo InPar: {maxInPar}");

                //b) Para cada uno de los grupos el porcentaje de números negativos y números positivos.

                float percPos = 100/(float)(inputCount) * (float)pos;
                float percNeg = 100/(float)inputCount * (float)neg;

                Console.WriteLine($"Porc Pos: {percPos} %");
                Console.WriteLine($"Porc Neg: {percNeg} %");

                inputCount = pos = neg = 0 ;
            }

            Console.WriteLine($"Total Positivos {totalPos}");
            Console.WriteLine("Termino Todos grupo");
        }

    }
}
