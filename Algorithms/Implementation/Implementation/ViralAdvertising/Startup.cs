using System;

namespace ViralAdvertising
{
    public class Startup
    {
        private static int CountOfPeopleWhoLikeTheAdvertisement(int numberOfDays)
        {
            int counter = 0;
            int numberOfPeople = 5;
            
            while (true)
            {
                if (numberOfDays == 0)
                {
                    break;
                }

                counter += numberOfPeople / 2;
                numberOfPeople = (numberOfPeople / 2) * 3;
                numberOfDays--;
            }

            return counter;
        }

        public static void Main()
        {
            int numberOfDays = int.Parse(Console.ReadLine());

            int countOfPeopleWhoLikeTheAdvertisement = CountOfPeopleWhoLikeTheAdvertisement(numberOfDays);
            Console.WriteLine(countOfPeopleWhoLikeTheAdvertisement);
        }
    }
}
