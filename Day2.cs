namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartOne();
            PartTwo();
        }

        private static void PartOne()
        {
            string filepath = @"C:\Users\Reelix\Desktop\AoC\Day 2\input.txt";
            List<string> fileLines = File.ReadAllLines(filepath).ToList();
            int totalScore = 0;
            foreach (string line in fileLines)
            {
                string[] chose = line.Split(' '); // Technically chars, but hey
                                                  // The score for a single round is the score for the shape you selected
                                                  // (1 for Rock, 2 for Paper, and 3 for Scissors)
                                                  // plus the score for the outcome of the round (0 if you lost, 3 if the round was a draw, and 6 if you won).
                                                  // A / X = Rock
                                                  // B / Y = Paper
                                                  // C / Z = Scissors

                switch (chose[1])
                {
                    // Rock
                    case "X":
                        totalScore += 1;
                        // Rock
                        if (chose[0] == "A")
                        {
                            totalScore += 3;
                        }
                        // Scissors
                        else if (chose[0] == "C")
                        {
                            totalScore += 6;
                        }
                        // Paper I lose, so 0
                        break;

                    // Paper
                    case "Y":
                        totalScore += 2;
                        // Rock
                        if (chose[0] == "A")
                        {
                            totalScore += 6;
                        }
                        // Paper
                        else if (chose[0] == "B")
                        {
                            totalScore += 3;
                        }
                        // Scissors I lose
                        break;

                    // Scissors
                    case "Z":
                        totalScore += 3;
                        // Paper
                        if (chose[0] == "B")
                        {
                            totalScore += 6;
                        }
                        // Scissors
                        else if (chose[0] == "C")
                        {
                            totalScore += 3;
                        }
                        // Rock I lose
                        break;
                }
            }
            Console.WriteLine(totalScore);
        }

        private static void PartTwo()
        {
            // Part 2 - Brute force, but hey
            string filepath = @"C:\Users\Reelix\Desktop\AoC\Day 2\input.txt";
            List<string> fileLines = File.ReadAllLines(filepath).ToList();
            int totalScore = 0;
            foreach (string line in fileLines)
            {
                string[] chose = line.Split(' ');

                // X = Lose
                // Y = Draw
                // Z = Win
                switch (chose[0])
                {
                    // Rock
                    case "A":
                        // Lose
                        if (chose[1] == "X")
                        {
                            totalScore += 3; // Scissors + Lose 
                        }
                        // Draw
                        else if (chose[1] == "Y")
                        {
                            totalScore += 4; // Rock + Draw
                        }
                        // Win
                        else if (chose[1] == "Z")
                        {
                            totalScore += 8; // Paper + Win
                        }
                        break;

                    // Paper
                    case "B":
                        // Lose
                        if (chose[1] == "X")
                        {
                            totalScore += 1; // Rock + Lose 
                        }
                        // Draw
                        else if (chose[1] == "Y")
                        {
                            totalScore += 5; // Paper + Draw
                        }
                        // Win
                        else if (chose[1] == "Z")
                        {
                            totalScore += 9; // Scissors + Win
                        }
                        break;

                    // Scissors
                    case "C":
                        // Lose
                        if (chose[1] == "X")
                        {
                            totalScore += 2; // Paper + Lose 
                        }
                        // Draw
                        else if (chose[1] == "Y")
                        {
                            totalScore += 6; // Scissors + Draw
                        }
                        // Win
                        else if (chose[1] == "Z")
                        {
                            totalScore += 7; // Rock + Win
                        }
                        break;
                }
            }
            Console.WriteLine(totalScore);
        }
    }
}
