﻿using System;

namespace _3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj średnią ocen");
            double srednia = double.Parse(Console.ReadLine());

            if (srednia > 2 && srednia < 4)
                Console.WriteLine("Stypendium 0zl.");
            else if (srednia >= 4 && srednia < 4.8)
                Console.WriteLine("Stypendium 250zl.");
            else if (srednia <= 5 && srednia >= 4.8)
                Console.WriteLine("Stypendium 550zl.");
            else
                Console.WriteLine("Nie mozna uzyskac takiej sredniej");

        }
    }
}

