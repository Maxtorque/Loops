﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.RandomNumbersGivenRange
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Random Numbers in Given Range";

            Console.WriteLine("Enter three numbers: n, min and max");
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter n   --> ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter min --> ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max --> ");
            int max = int.Parse(Console.ReadLine());

            while (min > max)
            {
                Console.WriteLine("You are need to enter number where is  min <= max");
                Console.Write("Enter min --> ");
                min = int.Parse(Console.ReadLine());
                Console.Write("Enter max --> ");
                max = int.Parse(Console.ReadLine());
            }

            Random random = new Random();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", random.Next(min, max + 1));
            }

            Console.WriteLine();
        }
    }
}
