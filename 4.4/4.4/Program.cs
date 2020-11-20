using System;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int i;
            int j;
            int k;
            int[] tablica;
            tablica = new int[100];

            for (i = 0; i < 100; i++)
            {
                tablica[i] = rand.Next(1, 1000);
                Console.Write("{0,8}", tablica[i]);
            }

            Console.WriteLine("\n Liczby pierwsze:  ");

            int sum = 0;
            for (j = 0; j < tablica.Length; j++)
            {
                for (k = 2; k < tablica[j]; k++)

                    if (tablica[j] % k == 0)
                    {

                        tablica[j] = 0;
                        break;
                    }
                if (k == tablica[j])
                    Console.Write("\n{0,8}", tablica[j]);
                {
                    if (tablica[j] > 0)
                        tablica[j] = 0 + 1;
                    sum = sum + tablica[j];

                }
            }
            Console.WriteLine("\n Ilosc cyfr pierwszych {0}", sum);

        }
    }
}
