using System;

namespace _4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jak duża ma być tablica:");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = new int[n];
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine("Podaj {0} liczbę", i + 1);
                tab1[i] = int.Parse(Console.ReadLine());
            }

                int max = tab1[0];
            for (int j = 0; j < tab1.Length; j++)
            {
                if (tab1[j] > max)
                {
                    max = tab1[j];
                }
            }
            Console.WriteLine("Najwieksza wartosc to {0},a jej pozycja to {1}", max, Array.IndexOf(tab1, max));

            int min = tab1[0];
            for (int k = 0; k < tab1.Length; k++)
            {
                if (tab1[k] < min)
                {
                    min = tab1[k];
                }
            }
            Console.WriteLine("Najmniejsza watosc to: {0},a jej pozycjq to {1}", min, Array.IndexOf(tab1, min));

            int sum = 0;
            double srednia = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                sum = sum + tab1[i];
                srednia = (double)sum / tab1.Length;
            }
            Console.WriteLine("Srednia w liczbo to {0}", srednia);

            int[] dodatnie = new int[tab1.Length];

            for (int i = tab1.Length - 1; i >= 0; i--)
                if (tab1[i] > 0)
                    dodatnie[tab1.Length - i - 1] = tab1[i];

            int suma = 0;
            for (int i = 0; i < dodatnie.Length; i++)
            {
                int ile = 0;
                if (dodatnie[i] > 0) ile++;

                suma = suma + ile;
            }
            Console.WriteLine("ilosc liczb dodatnich {0}.", suma);
            Console.ReadKey();
        }
    }
}
