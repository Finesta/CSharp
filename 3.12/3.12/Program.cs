using System;

namespace _3._12
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Wypisz liczby i zakończ zerem");
            int liczba,suma=0;
            liczba = int.Parse(Console.ReadLine());

            while (liczba > 0)
            {
                suma = suma + liczba;
                liczba = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Suma liczb wynosi {0}", suma);

        }
    }
}
