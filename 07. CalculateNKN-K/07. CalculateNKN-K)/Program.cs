using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CalculateNKN_K_
{
    class Program
    {
        static void Main()
        {
            int N, K;
            BigInteger result = 1;
            Console.Write("Enter the first number N:");
            bool isNInt = int.TryParse(Console.ReadLine(), out N);
            Console.Write("Enter the second number K:");
            bool isKInt = int.TryParse(Console.ReadLine(), out K);
            if (isNInt && isKInt && (N < K) && (N > 1) && (K > 1))
            {
                for (int i = 1; i < K + 1; i++)
                {
                    if (N > (K - N))
                    {
                        result = result * i;
                        if (i < (N + 1))
                        {
                            result = result * i;
                        }
                    }
                    else if (N < (K - N))
                    {
                        if (i <= N)
                        {
                            result = result * i;
                        }
                        if (i > (K - N))
                        {
                            result = result * i;
                        }
                    }
                    else//N=K-N
                    {
                        result = result * i;
                    }
                }
                Console.WriteLine("result={0}", result);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
