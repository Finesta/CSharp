using System;

namespace _3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba, silnia = 1;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)
                silnia *= i;

            Console.WriteLine(silnia);

            Console.ReadKey();

        }
    }
}