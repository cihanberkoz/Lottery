using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 100; j++)
            {
                Random number = new Random();
                int[] randomNumbers = new int[6];

                for (int i = 0; i < 6; i++)
                {
                    randomNumbers[i] = number.Next(1, 91);
                }
                Array.Sort(randomNumbers);

                if (randomNumbers[0] != randomNumbers[1] && randomNumbers[0] != randomNumbers[2] && randomNumbers[0] != randomNumbers[3] && randomNumbers[0] != randomNumbers[4] && randomNumbers[0] != randomNumbers[5] &&
                    randomNumbers[1] != randomNumbers[2] && randomNumbers[1] != randomNumbers[3] && randomNumbers[1] != randomNumbers[4] && randomNumbers[1] != randomNumbers[5] &&
                    randomNumbers[2] != randomNumbers[3] && randomNumbers[2] != randomNumbers[4] && randomNumbers[2] != randomNumbers[5] &&
                    randomNumbers[3] != randomNumbers[4] && randomNumbers[3] != randomNumbers[5] &&
                    randomNumbers[4] != randomNumbers[5])
                {
                    Console.Write("\nŞanslı Numaralar ---------->");

                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write("  " + randomNumbers[i] + "   ");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}

