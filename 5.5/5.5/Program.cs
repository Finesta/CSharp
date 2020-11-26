using System;

namespace zad._5._05
{
    class Program
    {
        static void rysuj(int a, int b, char znak)
        {
            for (int x = 0; x < a; x++)
            {
                for (int y = 0; y < b; y++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Podaj dlugosc:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokosc:");
            b = int.Parse(Console.ReadLine());

            rysuj(a, b, '*');
            Console.WriteLine();
            rysuj(b, a, '*');
            Console.ReadKey();
        }
    }
}
