using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeNumbers1_N
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Randomize the Numbers 1…N";

            Console.WriteLine("Enter number: ");
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter n --> ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random random = new Random();

            int randomNumber = random.Next(1, n + 1);
            array[0] = randomNumber;

            for (int i = 1; i < n; i++)
            {
                randomNumber = random.Next(1, n + 1);

                int count = 0;
                while (count <= i)
                {
                    if (array[count] == randomNumber)
                    {
                        randomNumber = random.Next(1, n + 1);
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }

                array[i] = randomNumber;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
