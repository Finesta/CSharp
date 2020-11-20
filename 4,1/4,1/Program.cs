using System;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy:");
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę całkowitą", i + 1);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write(liczby[i] + ", ");
            }
            Console.ReadKey();

        }
    }
}
