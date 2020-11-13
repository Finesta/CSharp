using System;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            int liczba1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczne liczbe");
            int liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 % liczba2 == 0)
            {
                Console.WriteLine("Jest dzielnikiem");
            }
            else
            {
                Console.WriteLine("Nie jest dzielnikiem");
            }
        }
    }
}
