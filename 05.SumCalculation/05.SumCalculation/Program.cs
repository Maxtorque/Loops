using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SumCalculation
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Calculate 1 + 1!/X + 2!/X2 + … + N!/XN";

            Console.WriteLine("Enter two numbers:");
            Console.WriteLine(new string('-', 40));
            Console.Write("Enter x --> ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter n --> ");
            int x = int.Parse(Console.ReadLine());
            int nFacturel = 1;
            double xPower = 1;
            double sum = 1;
            int counter = 1;

            while (counter <= n)
            {
                nFacturel *= counter;
                xPower = Math.Pow(x, counter);
                sum += (nFacturel / xPower);
                counter++;
            }

            Console.WriteLine("S = {0:0.00000}", sum);
        }
    }
}
