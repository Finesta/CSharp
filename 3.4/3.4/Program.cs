using System;

namespace _3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj druga liczbe");
            double b = double.Parse(Console.ReadLine());

            double c;

            Console.WriteLine("Wybierz operacje");
            Console.WriteLine("1.Dodawanie");
            Console.WriteLine("2.Odejmowanie");
            Console.WriteLine("3.Mnożenie");
            Console.WriteLine("4.Dzielenie");

            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("{0}",c);

                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("{0}", c);

                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("{0}", c);

                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("{0}", c);

                    break;
            }




        }
    }
}
