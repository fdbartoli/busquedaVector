//Se ingresa Número de legajo y promedio final de un conjunto de 10 estudiantes. Se desea obtener un
//listado ordenado por promedio de mayor a menor, con arrastre del legajo.

using System;

namespace arraybusqueda1
{
    class Program
    {
        static void Main(string[] args)

        {
            int[] legajo = new int[5];
            float[] promedio = new float[5];
            int k = 0;//0 desordenado, -1 ordenado
            int x = 5;//cantidad real de elementos del vector
            float auxpromedio = 0;
            int auxlegajo = 0;

            for (int i = 0; i < 5; i++)//INGRESO LOS NUMEROS DE LEGAJO Y LAS NOTAS
            {
                Console.WriteLine("Ingrese el número de legajo: ");
                legajo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el promedio final para el legajo " + legajo[i]);
                promedio[i] = float.Parse(Console.ReadLine());
            }

            while (k == 0)
            {
                k = 1;
                x--;
                for (int i = 0; i < x; i++)
                {
                    if (promedio[i] > promedio[i + 1])
                    {
                        k = 0;
                        auxpromedio = promedio[i];
                        promedio[i] = promedio[i + 1];
                        promedio[i + 1] = auxpromedio;

                        auxlegajo = legajo[i];
                        legajo[i] = legajo[i + 1];
                        legajo[i + 1] = auxlegajo;

                    }
                }
            }
            Console.WriteLine("\n\n\n******PROMEDIOS ORDENADOS DE MENOR A MAYOR******");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Número de legajo: " + legajo[i] + " promedio final: " + promedio[i]);
            }

        }
    }

}