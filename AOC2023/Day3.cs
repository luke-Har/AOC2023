using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AOC2023
{
    internal class Day3 : IAOCDay<int>
    {
        public string[] Input { get; set; }
        public string[] p1TestInput { get; set; }
        public string[] p2TestInput { get; set; }
        public int p1TestAnswer { get; set; }
        public int p2TestAnswer { get; set; }

        public Day3() 
        {
            p1TestInput = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day3testp1.txt");
            p1TestAnswer = 4361;
            Input = File.ReadAllLines("D:\\Coding\\c sharp\\AOC2023\\AOC2023\\day3input.txt");
        }

        public void Part1()
        {
            string[] stringarr = p1TestInput;


            int total = 0;
            for (int i = 0; i < stringarr.Length; i++)
            {
                for (int p = 0; p < stringarr[i].Length; p++)
                {
                    if (char.IsAsciiDigit(stringarr[i][p]) || stringarr[i][p] == '.') continue;

                    int[] idxpairs = { -1, -1, 0, -1, 1, -1, -1, 0, 1,0, -1, 1, 0, 1, 1,1 };
                    for (int m = 0; m < idxpairs.Length; m+=2)
                    {
                        int xidx = i + idxpairs[m];
                        int yidx = p + idxpairs[m + 1];
                        if (xidx < 0 || xidx >= stringarr[i].Length || yidx < 0 || yidx >= stringarr.Length) continue; //check bounds

                        if (char.IsAsciiDigit(stringarr[xidx][yidx])) //this works, need to just grow the search to cover the whole number rather than just the one found
                        {
                            
                            Console.WriteLine(stringarr[xidx][yidx]);
                        }
                    }
                }
            }

            Console.WriteLine(total);
            if(total == p1TestAnswer) Console.WriteLine("Jubilation! the answer is correct");
        }

        public void Part2()
        {
            throw new NotImplementedException();
        }
    }
}
