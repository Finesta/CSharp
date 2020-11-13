using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok");
            double rok = double.Parse(Console.ReadLine());

            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("Rok jest przestepny");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestepny");
            }
        }
    }
}