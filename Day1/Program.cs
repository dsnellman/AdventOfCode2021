using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DanielSnellman\source\repos\AdventOfCode2021\Day1\input.txt");

            part1(lines);
            part2(lines);
        }

        public static void part1(string[] lines)
        {
            int lastDeepth = 0;
            int increased = 0;
            foreach (string line in lines)
            {
                int currentLine = int.Parse(line);
                if (currentLine > lastDeepth && lastDeepth != 0)
                {
                    increased++;
                }

                lastDeepth = currentLine;
            }

            Console.WriteLine("Deepth increased " + increased + " times");

        }

        public static void part2(string[] lines)
        {
            List<int> Deepth = new List<int>();
            int LastSum = 0;
            int increased = 0;
            foreach (string line in lines)
            {
                int currentLine = int.Parse(line);
                if(Deepth.Count >= 2)
                {
                    int currentSum = currentLine + Deepth[0] + Deepth[1];
                    if(LastSum < currentSum && LastSum != 0)
                    {
                        increased++;
                    }
                    LastSum = currentSum;
                }

                Deepth.Insert(0, currentLine);
            }

            Console.WriteLine("Deepth increased " + increased + " times");

        }
    }
}
