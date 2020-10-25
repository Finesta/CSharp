using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double delta;
            Console.WriteLine("Podaj A");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj B");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj C");
            c = int.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);

            Console.WriteLine(delta);

            Console.ReadKey();


        }
    }
}
