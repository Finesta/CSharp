using System;

namespace _3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dlugosc przedziału (1,n)");

            int liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= liczba; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)
                    if (i % j == 0)
                        suma = suma + j;
                if (suma == i)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
