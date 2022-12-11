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
            List<string> list = File.ReadAllLines(@"C:\Users\Reelix\Desktop\AoC\Day 4\input.txt").ToList();
            int total = 0;
            foreach (string line in list)
            {
                string elf1 = line.Split(',')[0];
                string elf2 = line.Split(',')[1];
                
                int e1p1 = int.Parse(elf1.Split('-')[0]);
                int e1p2 = int.Parse(elf1.Split('-')[1]);
                int e2p1 = int.Parse(elf2.Split('-')[0]);
                int e2p2 = int.Parse(elf2.Split('-')[1]);

                if ((e1p1 >= e2p1 && e1p2 <= e2p2) && (e2p1 >= e1p1 && e2p2 <= e1p2))
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }

        static void Part2()
        {
            List<string> list = File.ReadAllLines(@"C:\Users\Reelix\Desktop\AoC\Day 4\input.txt").ToList();
            int total = 0;
            foreach (string line in list)
            {
                string elf1 = line.Split(',')[0];
                string elf2 = line.Split(',')[1];

                int e1p1 = int.Parse(elf1.Split('-')[0]);
                int e1p2 = int.Parse(elf1.Split('-')[1]);
                int e2p1 = int.Parse(elf2.Split('-')[0]);
                int e2p2 = int.Parse(elf2.Split('-')[1]);

                // 6-6 = 1 (y - x + 1)
                // 10-20 = 11 (y - x + 1)
                List<int> elf1List = Enumerable.Range(e1p1, (e1p2 - e1p1) + 1).ToList();
                List<int> elf2List = Enumerable.Range(e2p1, (e2p2 - e2p1) + 1).ToList();

                if (elf1List.Any(x => elf2List.Contains(x)))
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
