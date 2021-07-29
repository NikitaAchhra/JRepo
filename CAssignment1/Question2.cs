using System;
using System.Collections.Generic;
using System.Text;

namespace CAssignment1
{
    class Question2
    {
        static void Main()
        {
            int count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0,count5=0,count6 = 0;
            int totalRuns = 0;

            for (int i = 0; i < 30; i++)
            {
                Random random = new Random();
                int runs = random.Next(0, 7);
                totalRuns += runs;
                if (runs == 0) count0 += 1;
                else if (runs == 1) count1 += 1;
                else if (runs == 2) count2 += 1;
                else if (runs == 3) count3 += 1;
                else if (runs == 4) count4 += 1;
                else if (runs == 5) count5 += 1;
                else if (runs == 6) count6 += 1;
            }

            Console.WriteLine("Total Runs: {0}", totalRuns);
            Console.WriteLine("Number of 0s, 1s, 2s, 3s, 4s, 5s and 6s is {0},{1},{2},{3},{4},{5} and {6}",count0,count1,
                count2,count3,count4,count5,count6);

            Console.WriteLine("Strike Rate: {0}",(totalRuns/30)*100);

        }
    }
}
