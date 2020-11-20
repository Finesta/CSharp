using System;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 7, 5, 6 }, { 0, 0, 0 } };

            int y = 2;
            int z = 3;
            int[,] C = new int[y, z];

            Console.WriteLine("Tablica 1\n");
            int i;
            int j = 0;
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine();
            Console.WriteLine("Tabblica 2\n");
            int a;
            int b = 0;
            for (a = 0; a < 2; a++)
            {
                for (b = 0; b < 3; b++)
                {
                    Console.Write("{0,3}", B[a, b]);
                }
                Console.Write("\n");
            }
            Console.WriteLine();
            Console.WriteLine("Zsumowane:\n");
            int w, k;
            for (w = 0; w < 2; w++)
            {
                for (k = 0; k < 3; k++)
                {
                    C[w, k] = A[w, k] + B[w, k];
                    Console.Write("{0,3}", C[w, k]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
