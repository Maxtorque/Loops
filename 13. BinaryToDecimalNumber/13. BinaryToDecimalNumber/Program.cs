using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Binary to Decimal Number";

            Console.WriteLine("Enter number in Binary representacion: ");
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter Binary number --> ");
            string binaryNumber = Console.ReadLine();

            int count = binaryNumber.Length - 1;
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                decimalNumber += long.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, (count - i));
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
