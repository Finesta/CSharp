using System;

namespace _4._5
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

            int[] tab2 = new int[tab1.Length];

            Console.WriteLine("\n");

            Array.Copy(tab1, 0,tab2, 1, tab1.Length-1);
            Array.Copy(tab1, tab1.Length-1, tab2, 0, 1);
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine(tab1[i]);
            }
            Console.WriteLine();
            foreach (int a in tab2)
                Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
