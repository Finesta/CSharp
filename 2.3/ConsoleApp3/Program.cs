using System;
using System.Runtime.InteropServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, bmi;

            Console.WriteLine("Podaj wage w kilogramach");
            waga = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w metrach");
            wzrost = double.Parse(Console.ReadLine());

            bmi = waga / (wzrost * wzrost);

            Console.WriteLine(Math.Round(bmi, 2));

            Console.ReadKey();
        }
    }
}