namespace AOC2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Day1 d1 = new Day1();
            d1.Part1();
            d1.Part2();
        }
    }

    interface IAOCDay<T> 
    {
        string[] Input { get; set; }
        string[] p1TestInput { get; set; }
        string[] p2TestInput { get; set; }
        T p1TestAnswer { get; set; }
        T p2TestAnswer { get; set; }

        public abstract void Part1();
        public abstract void Part2();
    }
}
