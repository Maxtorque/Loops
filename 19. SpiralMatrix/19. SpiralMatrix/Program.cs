using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.SpiralMatrix
{
    class Program
    {
        static void Main()
        {
            //Nakraq na domashnoto veche zaciklih i ne mojah da se spravq s cqloto nqkyde
            //mi lipsva neshto no ne moga da razbera kyde :(
            int N;
            int counter  = 0;
            int numberofDoubleSections;
            int spiralSectionLength;
            byte column = 0;
            byte row = 0;
            Console.Write("Enter an integer number <20:");
            bool isnInt = int.TryParse(Console.ReadLine(), out N);
            if (isnInt & N < 20 & N > 0)
            {
                int[,] array = new int[N, N];
                for (column = 0; column < N; column++)
                {
                    counter++;
                    array [row, column] = counter;
                }
                column--;
                numberofDoubleSections = N - 1;
                spiralSectionLength = N - 1;
                counter++;
                for (int section = 0; section < numberofDoubleSections; section++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int i = 0; i <spiralSectionLength; i++)
                        {
                            if (j == 1)
                            {
                                if (section % 2 == 0)
                                {
                                    column--;
                                    array[row, column] = counter;
                                }
                                else
                                {
                                    column++;
                                    array[row, column] = counter;
                                }
                            }
                            else
                            {
                                if (section % 2 == 0)
                                {
                                    row++;
                                    array[row, column] = counter;
                                }
                                else
                                {
                                    row--;
                                    array[row, column] = counter;
                                }
                                else
                                {
                                    row--;
                                    array[row, column] = counter;
                                }
                            }
                            counter++;
                        }
                    }
                    spiralSectionLength--;
                }
                for (row = 0; row < N; row++)
                {
                    for (column = 0; column < N; column++)
                    {
                        Console.WriteLine("{0,4}", array[row, column]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong Entry!");





        }
    }
    }
}
