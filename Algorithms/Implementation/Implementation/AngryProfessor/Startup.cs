using System;
using System.Linq;

namespace AngryProfessor
{
    public class Startup
    {
        private static void IsTheClassCancelled(int studentsInClass, int cancelationThreshold, int[] arrivalTimes)
        {
            int arrivedOnTime = 0;

            for (int i = 0; i < studentsInClass; i++)
            {
                if (arrivalTimes[i] <= 0)
                {
                    arrivedOnTime++;
                }

                if (arrivedOnTime == cancelationThreshold)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }

        public static void Main()
        {
            int testCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int studentsInClass = input[0];
                int cancelationThreshold = input[1];

                int[] arrivalTimes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                IsTheClassCancelled(studentsInClass, cancelationThreshold, arrivalTimes);
            }
        }
    }
}
