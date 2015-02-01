using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy_3_and_7
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Enter an integer number:");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (((i % 3) != 0) || ((i % 7) != 0))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
