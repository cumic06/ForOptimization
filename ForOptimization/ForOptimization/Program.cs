using System;

namespace ForOptimization
{
    class Program
    {
        static void Main()
        {
            For();
            ForOptimization();
        }

        private static void For()
        {
            int realRunCount = 0;
            int workRunCount = 0;
            for (realRunCount = 1, workRunCount = 0; workRunCount < 100; realRunCount++)
            {
                realRunCount++;
                workRunCount++;
            }
            Console.WriteLine($"{realRunCount} {workRunCount} {100}");
        }

        private static void ForOptimization()
        {
            int realRunCount = 0;
            int workRunCount = 0;
            for (realRunCount = 1, workRunCount = 0; workRunCount < 100; realRunCount++)
            {
                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;

                realRunCount++;
                workRunCount++;
            }
            Console.WriteLine($"{realRunCount} {workRunCount} {100}");
        }
    }
}