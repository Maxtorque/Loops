using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Decimal_to_Binary_Number
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Decimal to Binary Number";

            Console.WriteLine("Enter number in Decimal representacion: ");
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter Decimal number --> ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = String.Empty;
            if (decimalNumber != 0)
            {
                while (decimalNumber > 0)
                {
                    binaryNumber += Convert.ToString(decimalNumber % 2);
                    decimalNumber /= 2;
                }

                for (int i = binaryNumber.Length - 1; i >= 0; i--)
                {
                    Console.Write(binaryNumber[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
