using ChallengeSolutions.Helpers;
using PuzzleSolutions.Y2021;
using System;

namespace PuzzleSolutions
{
    public class SolutionRunner
    {
        public static void Main()
        {
            MyIO.CreateEmptyDataFiles(2021);

            //Day1();
            Day2();
        }

        static void Day1()
        {
            var part1 = Y2021_D1.SolvePart1();
            var part2 = Y2021_D1.SolvePart2();
            Console.WriteLine($"Part 1 Answer: {part1}");
            Console.WriteLine($"Part 2 Answer: {part2}");
        }

        static void Day2()
        {
            var part1 = Y2021_D2.SolvePart1();
            Console.WriteLine($"Day 2 Part 1 Answer: {part1}");

            var part2 = Y2021_D2.SolvePart2();
            Console.WriteLine($"Day 2 Part 2 Answer: {part2}");
        }
    }
}
