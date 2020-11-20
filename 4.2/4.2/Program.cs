using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica1 = { 1, 2, -3, 4, 5, 6, -7, 8, -9, 10 };
            int[] tablica2 = new int[tablica1.Length];

            for (int i = tablica1.Length - 1; i >= 0; i--)
                if (tablica1[i] > 0)
                    tablica2[tablica1.Length - i - 1] = tablica1[i];

            for (int i = tablica2.Length -1 ; i >= 0; i--)
                if (tablica2[i] > 0)
                    Console.WriteLine(tablica2[i]);

            Console.ReadKey();

        }
    }
}
