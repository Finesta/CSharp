using System;

namespace zad._5._06
{
    class Program
    {
        static void mnozenie(string[] tablica, int x)
        {
            Console.WriteLine("\nPo mnożeniu:");

            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(tablica[i]);
                }
               
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj 5 wyrazow:");
            string[] tablica = new string[5];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Console.ReadLine();
            }

            Console.WriteLine("Podaj mnożnik:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Przed mnożeniem:");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write(tablica[i] + " ");
            }

            mnozenie(tablica, x);
        }
    }
}