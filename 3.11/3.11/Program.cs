﻿using System;

namespace _3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,suma = 0;
            for (int i = 1; suma <= 100; i++)
            {
                suma = suma + i;
                a = a + 1;
            Console.WriteLine(suma);

            }

            Console.WriteLine("Ilosc potrzebnych liczb wynosi {0}",a);

            Console.ReadKey();

        }
    }
}