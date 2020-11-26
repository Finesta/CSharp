using System;

namespace _5._2
{
    class Program
    {
        static void koniec(int a,int b,int x)
        {
           if (x >= a && x<=b)
                Console.WriteLine("Jest w przedziale");
           else
                Console.WriteLine("Nie jest w przedziale");
        }

        static void Main(string[] args)
        {
            int a=0, b=10, x;
            Console.WriteLine("Podaj przedzial a,b");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe");

            x = int.Parse(Console.ReadLine());
            koniec(a, b, x);
            Console.ReadKey();
        }
    }
}
