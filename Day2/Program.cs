using System;
using System.Collections.Generic;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DanielSnellman\source\repos\AdventOfCode2021\Day2\input.txt");

            part1(lines);
            part2(lines);
        }

        public static void part1(string[] lines)
        {
            int deepth = 0;
            int forward = 0;
            foreach (string line in lines)
            {
                string[] input = line.Split(' ');
                switch(input[0])
                {
                    case "forward":
                        forward += int.Parse(input[1]);
                        break;

                    case "up":
                        deepth -= int.Parse(input[1]);
                        break;

                    case "down":
                        deepth += int.Parse(input[1]);
                        break;

                }
            }

            Console.WriteLine("Forward: " + forward + " and Deepth: " + deepth + " and result :" + (deepth*forward));

        }

        public static void part2(string[] lines)
        {
            int deepth = 0;
            int forward = 0;
            int aim = 0;
            foreach (string line in lines)
            {
                string[] input = line.Split(' ');
                switch (input[0])
                {
                    case "forward":
                        forward += int.Parse(input[1]);
                        deepth += (aim * int.Parse(input[1]));
                        break;

                    case "up":
                        aim -= int.Parse(input[1]);
                        break;

                    case "down":
                        aim += int.Parse(input[1]);
                        break;

                }
            }

            Console.WriteLine("Forward: " + forward + " and Deepth: " + deepth + "and aim: " + aim + " and result :" + (deepth * forward));

        }
    }
}
