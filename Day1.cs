namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Reelix\Desktop\AoC\Day 1\input.txt";
            List<string> fileData = File.ReadLines(file).ToList();
            List<int> topElves = new List<int>();
            int current = 0;
            foreach (string line in fileData)
            {
                if (line == String.Empty)
                {
                    topElves.Add(current);
                    current = 0;
                }
                else
                {
                    current += int.Parse(line);
                }
            }
            topElves = topElves.OrderByDescending(x => x).ToList();
            Console.WriteLine(topElves[0] + topElves[1] + topElves[2]);
        }
    }
}
