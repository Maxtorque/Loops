using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverageNNumbers
{
    class Program
    {
        static void Main()
        {
            int n;
            string[] numbers;
            bool isInteger = true;
            int minimal = int.MaxValue;
            int maximal = int.MinValue;
            Console.Write("Enter a sequence of numbers delimited with \",\":");
            numbers = (Console.ReadLine()).Split(',');
            int[] intNumbers = new int[numbers.Length];
            for (int i = 0; i < (numbers.Length); i++)
            {
                isInteger = int.TryParse(numbers[i], out intNumbers[i]);
                if (isInteger == false)
                {
                    break;
                }
            }
            if (isInteger)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (intNumbers[i] < minimal)
                    {
                        minimal = intNumbers[i];
                    }
                    if (intNumbers[i] > maximal)
                    {
                        maximal = intNumbers[i];
                    }
                }
                Console.WriteLine("minimal={0}", minimal);
                Console.WriteLine("maximal={0}", maximal);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the entries are not integer!");
            }
        }
    }
}
