using System;

namespace GradingStudents
{
    public class Startup
    {
        private const int FAILING_GRADE = 38;
        private const int DIFFERENCE_NUMBER = 3;

        private static int[] ModifyGrades(int[] grades, int N)
        {
            int[] newGrades = new int[N];

            for (int i = 0; i < N; i++)
            {
                int currentGrade = grades[i];

                if(currentGrade % 5 < DIFFERENCE_NUMBER || currentGrade < FAILING_GRADE)
                {
                    newGrades[i] = currentGrade;
                }
                else
                {
                    newGrades[i] = currentGrade + (5 - (currentGrade % 5)); ;
                }
            }

            return newGrades;
        }

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] grades = new int[N];
            for (int i = 0; i < N; i++)
            {
                grades[i] = int.Parse(Console.ReadLine());
            }

            int[] newGrades = ModifyGrades(grades, N);
            for (int j = 0; j < N; j++)
            {
                Console.WriteLine(newGrades[j]);
            }
        }
    }
}
