using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TrailingZeroesInN_
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Trailing Zeroes in N!";

            Console.WriteLine("Enter number");
            Console.WriteLine(new string('-', 40));
            Console.Write("n  --> ");
            int n = int.Parse(Console.ReadLine());

            BigInteger nFactorel = 1;
            nFactorel = GetNFactorial(n, nFactorel);

            Console.WriteLine("n! --> {0}", nFactorel);
            Console.WriteLine(new string('_', 80));
       
            int countZero = 0;
            while (nFactorel % 10 == 0)
            {
                nFactorel = nFactorel / 10;
                countZero++;
            }

            Console.WriteLine("First method: {0}", countZero);

            int factorFive = 5;
            int dividParameter = 0;
            int count = 1;
            countZero = 0;

            for (int i = 0; i < n; i++)
            {
                dividParameter = (int)Math.Pow(factorFive, count);
                countZero += n / dividParameter;
                count++;
            }

            Console.WriteLine("Second method: {0}", countZero);
        }

        private static BigInteger GetNFactorial(int n, BigInteger nFactorel)
        {
            for (int i = 1; i <= n; i++)
            {
                nFactorel *= i;
            }

            return nFactorel;
        }
    }
}
