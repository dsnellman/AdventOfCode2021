using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\DanielSnellman\source\repos\AdventOfCode2021\Day3\input.txt");

            //part1(lines);
            part2(lines);
        }

        public static void part1(string[] lines)
        {
            int[] ones = new int[12];
            String gamma = "";
            String epsilon = "";
            foreach (string line in lines)
            {
                char[] input = line.ToCharArray();
                for(int x = 0; x < input.Length; x++)
                {
                    ones[x] += int.Parse(input[x].ToString());
                }
                   
            }

            foreach(int one in ones)
            {
                
                if(one > (lines.Length /2))
                {
                    gamma += '1';
                    epsilon += '0';
                }
                else
                {
                    gamma += '0';
                    epsilon += '1';
                }
            }

            

            Console.WriteLine("Gamma: " + gamma + ", " + Convert.ToInt32(gamma, 2) + "and epsilon: " + epsilon + ", " + Convert.ToInt32(epsilon, 2) + " and result :" + (Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2)));

        }

        public static void part2(string[] lines)
        {
            string OxygenRate = "";
            string ScrubberRate = "";
            
            List<string> leftOxygen = new List<string>(lines);
            List<string> leftScrubber = new List<string>(lines);
            int nLeftOxygen = leftOxygen.Count;
            int nLeftScrubber = leftScrubber.Count;

            for (int x = 0; x < lines[0].Length; x++)
            {
                leftOxygen.RemoveAll(p => p == "x");
                leftScrubber.RemoveAll(p => p == "x");
                char common = getCommonCharByIndex(leftOxygen, x);
                char lesscommon = getLessCommonCharByIndex(leftScrubber, x);

                for (int y = 0; y < leftOxygen.Count; y++)
                {
                    char[] input = leftOxygen[y].ToCharArray();
                    
                    if (input[0] != 'x' && input[x] != common)
                    {
                        if (nLeftOxygen > 1)
                        {
                            leftOxygen[y] = "x";
                            nLeftOxygen -= 1;
                        }   
                    }
                    if(nLeftOxygen == 1)
                    {
                        break;
                    }
                }

                for (int y = 0; y < leftScrubber.Count; y++)
                {
                    char[] input = leftScrubber[y].ToCharArray();

                    if (input[0] != 'x' && input[x] != lesscommon)
                    {
                        if (nLeftScrubber > 1)
                        {
                            leftScrubber[y] = "x";
                            nLeftScrubber -= 1;
                        }
                    }
                    if (nLeftScrubber == 1)
                    {
                        break;
                    }
                }






            }

            foreach (string value in leftOxygen)
            {
                if(value != "x")
                {
                    OxygenRate = value;
                    break;
                }
            }

            foreach (string value in leftScrubber)
            {
                if (value != "x")
                {
                    ScrubberRate = value;
                    break;
                }
            }




            Console.WriteLine("Oxygen rate: " + OxygenRate + ", " + Convert.ToInt32(OxygenRate, 2) + "and ScrubberRate: " + ScrubberRate + ", " + Convert.ToInt32(ScrubberRate, 2) + " and result : " + (Convert.ToInt32(OxygenRate, 2) * Convert.ToInt32(ScrubberRate, 2)));

        }

        public static char getCommonCharByIndex(List<String> lines, int index)
        {
            int ones = 0;
            foreach (string line in lines)
            {
                ones += int.Parse(line[index].ToString());
            }
            decimal averageNumber = (decimal)lines.Count / 2;
            if ((decimal)ones >= averageNumber)
            {
                return '1';
            }
            else
            {
                return '0';
            }
        }

        public static char getLessCommonCharByIndex(List<String> lines, int index)
        {
            int ones = 0;
            foreach (string line in lines)
            {
                ones += int.Parse(line[index].ToString());
            }
            decimal averageNumber = (decimal)lines.Count / 2;
            if ((decimal)ones >= averageNumber)
            {
                return '0';
            }
            else
            {
                return '1';
            }
        }
    }
}
