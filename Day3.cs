namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
        }

        static void Part1()
        {
            List<string> list = File.ReadAllLines(@"C:\Users\Reelix\Desktop\AoC\Day 3\input.txt").ToList();
            int total = 0;
            foreach (string line in list)
            {
                string p1 = line.Substring(0, line.Length / 2);
                string p2 = line.Substring(line.Length / 2);
                List<char> matchList = p1.Where(p2.Contains).Distinct().ToList();

                foreach (char c in matchList)
                {
                    int toAdd = 0;
                    if (char.IsLower(c))
                    {
                        // a is 97
                        // 97 - 96 = 1 (a)
                        toAdd = (int)c - 96;
                    }
                    else
                    {
                        // A is 65
                        // 65 - 38 = 27 (A)
                        toAdd = (int)c - 38;
                    }
                    total += toAdd;
                }
            }
            Console.WriteLine(total);
        }

        static void Part2()
        {
            List<string> list = File.ReadAllLines(@"C:\Users\Reelix\Desktop\AoC\Day 3\input2.txt").ToList();
            int total = 0;
            List<string[]> chunkList = list.Chunk(3).ToList();
            foreach (string[] item in chunkList)
            {
                List<string> chunkItems = item.ToList();
                List<char> uniqueChars = chunkItems[0].Where(chunkItems[1].Contains).Where(chunkItems[2].Contains).Distinct().ToList();
                foreach (char c in uniqueChars)
                {
                    if (char.IsLower(c))
                    {
                        // a is 97
                        // 97 - 96 = 1 (a)
                        total += (int)c - 96;
                    }
                    else
                    {
                        // A is 65
                        // 65 - 38 = 27 (A)
                        total += (int)c - 38;
                    }
                }
            }
            Console.WriteLine(total);
        }
    }
}
