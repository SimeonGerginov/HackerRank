using System;
using System.Collections.Generic;
using System.Linq;

namespace ACMICPCTeam
{
    public class Startup
    {
        private static int[] MaximumNumberOfTopicsATeamCanKnow(string[] topics, int numberOfTopics)
        {
            int[] result = new int[2];
            List<int> combinations = new List<int>();
            int counter = 0;

            for (int i = 0; i < topics.Length - 1; i++)
            {
                string currentTopic = topics[i];
                for (int j = i + 1; j < topics.Length; j++)
                {
                    string nextTopic = topics[j];
                    for (int k = 0; k < numberOfTopics; k++)
                    {
                        if (currentTopic[k] == '1' || nextTopic[k] == '1')
                        {
                            counter++;
                        }
                    }

                    combinations.Add(counter);
                    counter = 0;
                }
            }

            int maxNumberOfTopics = combinations.Max();
            int countOfMaxNumberOfTopics = combinations.Where(c => c == maxNumberOfTopics).Count();

            result[0] = maxNumberOfTopics;
            result[1] = countOfMaxNumberOfTopics;

            return result;
        }

        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfAttendees = input[0];
            int numberOfTopics = input[1];

            string[] topics = new string[numberOfAttendees];
            for (int i = 0; i < numberOfAttendees; i++)
            {
                string topic = Console.ReadLine();
                topics[i] = topic;
            }

            int[] result = MaximumNumberOfTopicsATeamCanKnow(topics, numberOfTopics);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
