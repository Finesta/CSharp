using System;

namespace zad._5._09
{
    class Program
    {

        static int it(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                b += a;
                a = b - a;
            }
            return a;
        }

        static int r(int n)
        {
            if ((n == 1) || (n == 2))
                return 1;
            else
                return r(n - 1) + r(n - 2);
        }

        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Podaj dlugosc ciagu");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} wyraz ciagu (rekurencja): {1}", n, r(n));
            Console.WriteLine("{0} wyraz ciagu (iteracja): {1}", n, it(n));
        }
    }

}