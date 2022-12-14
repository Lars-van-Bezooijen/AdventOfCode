using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2022.Day1
{
    internal class Day1
    {
        List<List<int>> elves = new List<List<int>>();
        List<int> currentElve = new List<int>();
        List<int> calories = new List<int>();

        public void CountCalories()
        {
            Console.WriteLine("- Day 1 -");
            ReadFile();
            HighestCalories();
            Console.WriteLine();
        }

        // Read file and add to list
        public void ReadFile()
        {
            foreach (var line in File.ReadLines(@"2022/Day1/input.txt"))
            {
                if (string.IsNullOrEmpty(line))
                {
                    elves.Add(currentElve);
                    currentElve = new List<int>();
                }
                else
                {
                    int value = int.Parse(line);
                    currentElve.Add(value);
                }
            }
            elves.Add(currentElve);
        }


        // Get sum of top 3 elves with most calories
        public void HighestCalories()
        {
            foreach (var elve in elves)
            {
                int sum = elve.Sum();
                calories.Add(sum);
            }
            calories.Sort();
            calories.Reverse();
            int totalCals = calories[0] + calories[1] + calories[2];
            Console.WriteLine("Highest calories: " + totalCals);
        }


    }
}
