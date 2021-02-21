using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkLesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix.Draw();
        }
    }
    static class Matrix
    {
        private static List<string> symbolsList = new List<string>()
        {
            "d",
            "a",
            "5",
            "l",
            "j",
            "9",
            "p",
            "R",
            "1",
            "k",
            "d",
            "4",
            "d",
            "l",
            "j",
            "9",
            "d",
            "4",
            "l",
            "j",
            "p",
            "R",
            "1",
            "2",
        };

        public static void Draw()
        {
            Random rdLength = new Random();
            int randLength = rdLength.Next(2,10);
            Random rdSymbol = new Random();

            for (int i = 0; i < randLength; i++)
            {
                if (i == randLength - 1)
                {
                    int randSymbol = rdSymbol.Next(0,24);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(symbolsList[randSymbol]);
                    Console.ResetColor();
                }
                else if (i == randLength - 2)
                {
                    int randSymbol = rdSymbol.Next(0,24);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(symbolsList[randSymbol]);
                    Console.ResetColor();
                }
                else
                {
                    int randSymbol = rdSymbol.Next(0,24);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(symbolsList[randSymbol]);
                    Console.ResetColor();
                }
            }
        }
    }
}
