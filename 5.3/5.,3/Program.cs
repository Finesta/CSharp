using System;

namespace _5._03
{
    class Program
    {
        static void Przesun(ref int[,] tablica)
        {

            int x, y;
            int[,] wek = new int[1, 2] { { 3, 2 } };
            for (x = 0; x < 1; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    tablica[x, y] = tablica[x, y] + wek[x, y];
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] tablica = new int[1, 2];
            Console.WriteLine("Podaj wspolrzedne punktu A: ");
            for (int a = 0; a < 1; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    tablica[a, b] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Wspolrzędne po przesunieciu o wektor[3,2]:");
            Przesun(ref tablica);
            foreach (int x in tablica)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
