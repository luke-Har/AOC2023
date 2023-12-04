using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2023
{
    internal class Day2 : IAOCDay<int>
    {
        public string[] Input { get; set; }
        public string[] p1TestInput { get; set; }
        public string[] p2TestInput { get; set; }
        public int p1TestAnswer { get; set; }
        public int p2TestAnswer { get; set; }

        public Day2() 
        {
            Input = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day2input.txt");
            p1TestInput = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day2testp1.txt");
            p1TestAnswer = 8;
            p2TestAnswer = 2286;
        }

        public void Part1()
        {
            Dictionary<string, int> ColourToAmount = new Dictionary<string, int>()
            {
                {"red",12 },
                {"green", 13},
                {"blue", 14 }
            };

            //string[] stringarr = p1TestInput;
            string[] stringarr = Input;
            int total = 0;
            for (int i = 0; i < stringarr.Length; i++)
            {
                string[] split = stringarr[i].Split(new char[] {' ', ',', ':', ';' }).Where(i => { return !string.IsNullOrWhiteSpace(i); }).ToArray();
                int ID = int.Parse(split[1]);
                bool isPossible = true;
                for (int p = 2; p < split.Length; p+=2)
                {
                    if (int.Parse(split[p]) > ColourToAmount[split[p + 1]]) isPossible = false;
                }
                if (isPossible) { total += ID; }
            }

            Console.WriteLine(total);
            //if(total == p1TestAnswer) Console.WriteLine("YIPEEE the answer is correct");
        }

        public void Part2()
        {


            //string[] stringarr = p1TestInput;
            string[] stringarr = Input;
            int total = 0;
            for (int i = 0; i < stringarr.Length; i++)
            {
                Dictionary<string, int> colourtomost = new Dictionary<string, int>() {
                    { "green", 0},
                    { "red", 0},
                    { "blue", 0}
                };

                string[] split = stringarr[i].Split(new char[] { ' ', ',', ':', ';' }).Where(i => { return !string.IsNullOrWhiteSpace(i); }).ToArray();

                for (int p = 2; p < split.Length; p += 2)
                {
                    if (colourtomost[split[p + 1]] < int.Parse(split[p])) { colourtomost[split[p + 1]] = int.Parse(split[p]); }
                }

                total += colourtomost["green"] * colourtomost["red"] * colourtomost["blue"];
            }

            Console.WriteLine(total);
            //if(total == p2TestAnswer) Console.WriteLine("YIPEEE the answer is correct");
        }
    }
}
