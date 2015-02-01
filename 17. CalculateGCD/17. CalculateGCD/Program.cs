using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class Program
    {
        static void Main()
        {
            uint N, K, temporary, remaining;
            uint greatestCommonDevider = 1;
            Console.Write("Enter the first number N:");
            bool isNUint = uint.TryParse(Console.ReadLine(), out N);
            Console.Write("Enter the second number K:");
            bool isKUint = uint.TryParse(Console.ReadLine(), out K);

            if (isNUint && isKUint && (N != 0 || K != 0))
            {
                if (N == 0)
                {
                    greatestCommonDevider = K;
                }
                else if (K == 0)
                {
                    greatestCommonDevider = N;
                }
                else
                {
                    temporary = Math.Max(N, K);
                    K = Math.Min(N, K);
                    N = temporary;
                    do
                    {
                        remaining = N % K;
                        if (remaining == 0)
                        {
                            greatestCommonDevider = K;
                            break;
                        }
                        else
                        {
                            N = K;
                            K = remaining;
                        }
                    } while (true);
                }
                Console.WriteLine("Greatest common devider = {0}", greatestCommonDevider);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
