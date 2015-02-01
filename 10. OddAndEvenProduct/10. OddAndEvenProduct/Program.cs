using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Odd and Even Product";

            Console.Write("Enter sequence of numbers: ");
            string[] sequenceNumber = Console.ReadLine().Split();
            Console.WriteLine(new string('-', 40));

            int productOddNumbers = 1;
            for (int i = 0; i < sequenceNumber.Length; i = i + 2)
            {
                productOddNumbers *= int.Parse(sequenceNumber[i]);
            }

            int productEvenNumbers = 1;
            for (int i = 1; i < sequenceNumber.Length; i = i + 2)
            {
                productEvenNumbers *= int.Parse(sequenceNumber[i]);
            }

            if (productOddNumbers == productEvenNumbers)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", productEvenNumbers);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", productOddNumbers);
                if (sequenceNumber.Length == 1)
                {
                    Console.WriteLine("even_product = no even numbers");
                }
                else
                {
                    Console.WriteLine("even_product = {0}", productEvenNumbers);
                }
            }
        }
    }
}
