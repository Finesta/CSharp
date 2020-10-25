using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celcjusza");
            C = double.Parse(Console.ReadLine());
            F = (( 9.0 / 5 ) * C ) + 32;
            Console.WriteLine(F);
            Console.ReadKey();
        }

    }
}
