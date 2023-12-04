using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2023
{
    internal class Day1 : IAOCDay<int>
    {
        public string[] Input { get; set; }
        public string[] p1TestInput { get; set; }
        public string[] p2TestInput { get; set; }
        public int p1TestAnswer { get; set; }
        public int p2TestAnswer { get; set; }

        public Day1() 
        {
            Input = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day1input.txt");
            p1TestInput = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day1testp1.txt");
            p2TestInput = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day1testp2.txt");
            p1TestAnswer = 142;
            p2TestAnswer = 281;
        }

        public void Part1()
        {
            //string[] stringarr = p1TestInput;
            string[] stringarr = Input;
            int testout = 0;
            for (int i = 0; i < stringarr.Length; i++)
            {
                bool isFirst = true;
                string currentNum = "";
                string num = "";
                for (int p = 0; p < stringarr[i].Length; p++)
                {
                    if (stringarr[i][p] >= 48 && stringarr[i][p] <= 57) 
                    {
                        if (isFirst) { num += stringarr[i][p]; isFirst = false; }
                        else { currentNum = stringarr[i][p].ToString(); }
                    }
                }
                if (currentNum == "") num += num;
                else num += currentNum;

                testout += int.Parse(num);
            }
            Console.WriteLine(testout);
            //if (testout == p1TestAnswer) Console.WriteLine($"Hazzah test value {testout} is correct");
        }

        public void Part2()
        {
            Dictionary<string, string> wordtonum = new Dictionary<string, string>
            {
                { "one", "1" },
                { "two", "2" },
                { "three", "3" },
                { "four", "4"},
                { "five", "5" },
                { "six", "6" },
                { "seven", "7" },
                { "eight", "8" },
                { "nine", "9" },
            };

            //string[] stringarr = p2TestInput;
            string[] stringarr = Input;
            int testout = 0;
            for (int i = 0; i < stringarr.Length; i++)
            {
                bool isFirst = true;
                string currentNum = "";
                string num = "";
                for (int p = 0; p < stringarr[i].Length; p++)
                {
                    if (stringarr[i][p] >= 48 && stringarr[i][p] <= 57)
                    {
                        if (isFirst) { num += stringarr[i][p]; isFirst = false; }
                        else { currentNum = stringarr[i][p].ToString(); }
                    }
                    else 
                    {
                        for (int m = 2; m <= 4; m++)
                        {
                            if (p < stringarr[i].Length - m) //Check 3/4/5 size window
                            {
                                string window = stringarr[i].Substring(p, m+1);
                                if (wordtonum.ContainsKey(window))
                                {
                                    if (isFirst) { num += wordtonum[window]; isFirst = false; }
                                    else { currentNum = wordtonum[window]; }
                                }
                            }
                        }
                    }
                  
                }
                if (currentNum == "") num += num;
                else num += currentNum;

                testout += int.Parse(num);
            }
            Console.WriteLine(testout);
            //if (testout == p2TestAnswer) Console.WriteLine($"Hazzah test value {testout} is correct");
        }
    }
}
