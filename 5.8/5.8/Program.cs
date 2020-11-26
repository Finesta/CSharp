using System;

namespace _5._8
{
    class Program
    {
        static void suma(string liczba)
            {
                int a = 0;

                for (int i = 0; i < liczba.Length; i++)
                   a = a + (Convert.ToInt16(liczba[i].ToString())); 

                Console.WriteLine("Suma cyfr liczby {0} wynosi {1}", liczba, a);
            }

        static void Main(string[] args)
            {
                Console.WriteLine("Podaj liczbę całkowitą.");
                string liczba = Console.ReadLine();
                suma(liczba);
            }
    }
}
