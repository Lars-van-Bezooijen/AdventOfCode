using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Left column: what the opponent will pick
A: Rock
B: Paper
C: Scissors

Right column: what you must play
X: Rock
Y: Paper
Z: Scissors

Your total score is the sum of your scores for each round.
---
The score for a single round is the score for the shape you selected 
(1 for Rock, 2 for Paper, and 3 for Scissors) 
plus the score for the outcome of the round 
(0 if you lost, 3 if the round was a draw, and 6 if you won).

 
 */

namespace AdventOfCode._2022.Day2
{
    internal class Day2
    {
        int score = 0;
        List<List<string>> sets = new List<List<string>>();

        public void RockPaperSciccors()
        {
            Console.WriteLine("- Day 2 -");
            ReadFile();
            CalculateScore();
            Console.WriteLine();
        }

        public void ReadFile()
        {
            foreach (var line in File.ReadLines(@"2022/Day2/input.txt"))
            {
                if (line.Split().Count() < 2) continue;
                sets.Add(line.Split().ToList());
            }
        }

        public void CalculateScore()
        {
            foreach (var set in sets)
            {
                // Rock vs Rock
                if (set[0] == "A" && set[1] == "X")
                {
                    score += 1 + 3;
                }
                // Rock vs Paper
                else if (set[0] == "A" && set[1] == "Y")
                {
                    score += 2 + 6;
                }
                // Rock vs Scissors
                else if (set[0] == "A" && set[1] == "Z")
                {
                    score += 3 + 0;
                }

                // Paper vs Rock
                else if (set[0] == "B" && set[1] == "X")
                {
                    score += 1 + 0;
                }
                // Paper vs Paper
                else if (set[0] == "B" && set[1] == "Y")
                {
                    score += 2 + 3;
                }
                // Paper vs Scissors
                else if (set[0] == "B" && set[1] == "Z")
                {
                    score += 3 + 6;
                }

                // Scissors vs Rock
                else if (set[0] == "C" && set[1] == "X")
                {
                    score += 1 + 6;
                }
                // Scissors vs Paper
                else if (set[0] == "C" && set[1] == "Y")
                {
                    score += 2 + 0;
                }
                // Scissors vs Scissors
                else if (set[0] == "C" && set[1] == "Z")
                {
                    score += 3 + 3;
                }
            }
            Console.WriteLine("Score: " + score);
        }
    }
}
