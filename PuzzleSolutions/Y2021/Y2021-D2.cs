using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D2
    {
        public static int SolvePart1()
        {
            List<string> puzzleInput = MyIO.ReadStringsFromFile(2021, 2, 1);

            int i = 0;
            int j = 0;
            string[] arg = { };

            foreach (string str in puzzleInput)
            {
                arg = str.Split(" ");

                switch (arg[0])
                {
                    case "forward":
                        i += int.Parse(arg[1]);
                        break;
                    case "up":
                        j -= int.Parse(arg[1]);
                        break;
                    case "down":
                        j += int.Parse(arg[1]);
                        break;
                }
            }

            return i * j;
        }

        public static int SolvePart2()
        {
            List<string> puzzleInput = MyIO.ReadStringsFromFile(2021, 2, 1);

            int pos = 0;
            int depth = 0;
            int aim = 0;
            string[] arg = { };

            foreach (string str in puzzleInput)
            {
                arg = str.Split(" ");

                switch (arg[0])
                {
                    case "down":
                        aim += int.Parse(arg[1]);
                        break;
                    case "up":
                        aim -= int.Parse(arg[1]);
                        break;
                    case "forward":
                        pos += int.Parse(arg[1]);
                        depth += aim * int.Parse(arg[1]);
                        break;
                }
            }

            return pos * depth;
        }
    }
}
