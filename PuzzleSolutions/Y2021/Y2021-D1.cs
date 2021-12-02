using ChallengeSolutions.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleSolutions.Y2021
{
    public static class Y2021_D1
    {
        public static int SolvePart1()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);

            int highest = 0;

            for (int i = 0; i < puzzleInput.Count - 1; i++)
            {
                if (puzzleInput[i] < puzzleInput[i + 1])
                    highest++;
            }

            return highest;
        }

        public static int SolvePart2()
        {
            List<int> puzzleInput = MyIO.ReadIntsFromFile(2021, 1, 1);

            int highest_avg = 0;

            for (int i = 0; i < puzzleInput.Count - 3; i++)
            {
                if (puzzleInput[i] + puzzleInput[i + 1] + puzzleInput[i + 2] < puzzleInput[i + 1] + puzzleInput[i + 2] + puzzleInput[i + 3])
                {
                    highest_avg++;
                }
            }

            return highest_avg;
        }
    }
}
