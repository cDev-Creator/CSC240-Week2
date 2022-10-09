using System;
using static System.Console;

namespace CSC240_02_02_ArrayDemo2_NGM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[8];
            int x;
            string inputString;

            void dashedline()
            {
                int count;
                const int DASHES = 50;
                for (count = 0; count < DASHES; ++count)
                    Write("-");
                WriteLine();
            }

            for (x = 0; x < scores.Length; ++x)
            {
                Write("Enter your score on test {0} ", x + 1);
                inputString = ReadLine();
                scores[x] = Convert.ToInt32(inputString);
            }

            dashedline();
            WriteLine("Scores in original order:");
            for(x = 0; x < scores.Length; x++)
            {
                Write("{0, 6}", scores[x]);
            };
            WriteLine();

            dashedline();
            Array.Sort(scores);
            WriteLine("Scores in sorted order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);
            WriteLine();

            dashedline();
            Array.Reverse(scores);
            WriteLine("Scores in reverse order:");
            for (x = 0; x < scores.Length; ++x)
                Write("{0, 6}", scores[x]);
            WriteLine();
            dashedline();
        }
    }
}
