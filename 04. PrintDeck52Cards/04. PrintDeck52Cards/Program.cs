using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintDeck52Cards
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    switch (j)
                    {
                        case 0: Console.Write("Ace"); break;
                        case 1: Console.Write("Two"); break;
                        case 2: Console.Write("Three"); break;
                        case 3: Console.Write("Four"); break;
                        case 4: Console.Write("Five"); break;
                        case 5: Console.Write("Six"); break;
                        case 6: Console.Write("Seven"); break;
                        case 7: Console.Write("Eight"); break;
                        case 8: Console.Write("Nine"); break;
                        case 9: Console.Write("Ten"); break;
                        case 10: Console.Write("Jack"); break;
                        case 11: Console.Write("Queen"); break;
                        case 12: Console.Write("King"); break;
                    }
                    switch (i)
                    {
                        case 0: Console.WriteLine(" Of Clubs"); break;
                        case 1: Console.WriteLine(" Of Diamonds"); break;
                        case 2: Console.WriteLine(" Of Hearts"); break;
                        case 3: Console.WriteLine(" Of Spades"); break;
                    }
                }
            }
        }
    }
}
