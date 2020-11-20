using System;

namespace _4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablica2d = new int[5, 5] { { 1, 2, 1, 2, 1}, { 3, 4, 3, 4, 3 }, { 5, 6, 5, 6, 5 }, { 7, 8 , 7 , 8 ,7}, { 9, 0, 9, 0, 9} };
            int sumprz = 0;

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("{0,3}", tablica2d[x, y]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int y = 0; y < 5; y++)
            {
                sumprz = sumprz + tablica2d[y,y];
            }

            Console.WriteLine("Suma przekatnej to {0}",sumprz);

            Console.ReadKey();

        }
    }
}
