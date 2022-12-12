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

Winning everytime is sus

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

        public void RockPaperSciccors()
        {
            Console.WriteLine("- Day 2 -");
            ReadFile();
            Console.WriteLine();
        }

        public void ReadFile()
        {

            foreach (var chars in File.ReadAllText("\\Users\\HeadShopper\\source\\repos\\AdventOfCode\\AdventOfCode\\2022\\Day2\\example_input.txt"))
            {
                if (chars == 'A')
                {



                    if (chars == 'X') // rock vs rock (Draw)
                    {
                        ScoreDraw();

                    }
                    else if (chars == 'Y') // rock vs paper (Win)        ----        this is first line in example input
                    {
                        ScoreWin();
                        Console.WriteLine("A/Y" + score);
                    }
                    else if (chars == 'Z') // rock vs sciccors (Loss)
                    {

                    }

                }
                Console.WriteLine(score);
            }
        }

        // scoring methods
        public void ScoreRock()
        {
            score += 1;
        }

        public void ScorePaper()
        {
            score += 2;
        }

        public void ScoreSciccors()
        {
            score += 3;
        }

        public void ScoreDraw()
        {
            score += 3;
        }

        public void ScoreWin()
        {
            score += 6;
        }
    }
}
