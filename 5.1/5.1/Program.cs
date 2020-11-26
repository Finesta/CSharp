using System;

namespace zad._5._01
{
    class Program
    {
        static void temperatura(double far)
        {
            double cel = (far - 32) / 1.8;
            Console.WriteLine("W celcjuszach to: {0}", cel);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temperaturę w farenheitah:");
            double far = double.Parse(Console.ReadLine());
            temperatura(far);
            Console.ReadKey();
        }
    }
}