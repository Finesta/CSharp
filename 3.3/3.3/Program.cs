using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj trzecia liczbe");
            int c = int.Parse(Console.ReadLine());

            if (a > b & a > c)
            {
                Console.WriteLine("Liczba {0} jest najwieszka",a);
            }
            else if (b > a & b > c)
            {
                Console.WriteLine("Liczba {0} jest najwieszka",b);
            }
            else
            {
                Console.WriteLine("Liczba {0} jest najwieszka");
            }
        }
    }
}
