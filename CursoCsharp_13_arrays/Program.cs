using System;

namespace CursoCsharp_13_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //type[] nombreArray;

            int[] arrayDeEnteros;
            int[] arrayDeEnteros2 = new int[5];
            int[] arrayDeEnteros3 = { 1, 2, 3, 4 };
            int[,] arrayDeEnteros2Dimensiones = new int[2, 2];
            int[,] arrayDeEnteros2Dimensiones2 = { { 2, 2 }, { 3, 6 } };
            int[][] arrayDeEnterosEscalonados = new int[6][];
            arrayDeEnterosEscalonados[0] = new int[4] { 3, 6, 7, 2 };
            arrayDeEnterosEscalonados[1] = new int[2] { 1, 3 };

            for (int i = 0; i < arrayDeEnteros3.Length; i++)
            {
                Console.WriteLine(arrayDeEnteros3[i]);
            }

            for (int i = 0; i < arrayDeEnteros2Dimensiones2.GetLongLength(0); i++)
            {
                for (int x = 0; x < arrayDeEnteros2Dimensiones2.GetLongLength(1); x++)
                {
                    Console.WriteLine(arrayDeEnteros2Dimensiones2[i, x]);
                }
            }

            for (int i = 0; i < arrayDeEnterosEscalonados.GetLongLength(0); i++)
            {
                for (int x = 0; x < arrayDeEnterosEscalonados.GetLongLength(1); x++)
                {
                    Console.WriteLine(arrayDeEnterosEscalonados[i][x]);
                }
            }


            foreach (var elementos in arrayDeEnteros3)
            {
                Console.WriteLine(elementos);
            }


        }
    }
}
