using System;

namespace zad._5._04
{
    class Program
    {
        static void mnozenie(int[] num, int x)
        {
            Console.WriteLine("\n Po mnożeniu:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = num[i] * x;
                Console.Write(num[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby:");
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Podaj liczbe przez ktora beda mnozone:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Wynik:");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }

            mnozenie(num, x);
        }
    }
}