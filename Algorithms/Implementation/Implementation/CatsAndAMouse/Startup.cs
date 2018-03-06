namespace CatsAndAMouse
{
    using System;
    using System.Linq;

    public class Startup
    {
        private static void AnswerOfQuery(int firstCatLocation, int secondCatLocation, int mouseLocation)
        {
            int distanceBetweenFirstCatAndMouse = Math.Abs(firstCatLocation - mouseLocation);
            int distanceBetweenSecondCatAndMouse = Math.Abs(secondCatLocation - mouseLocation);

            if (distanceBetweenFirstCatAndMouse == distanceBetweenSecondCatAndMouse)
            {
                Console.WriteLine("Mouse C");
            }
            else if (distanceBetweenFirstCatAndMouse > distanceBetweenSecondCatAndMouse)
            {
                Console.WriteLine("Cat B");
            }
            else
            {
                Console.WriteLine("Cat A");
            }
        }

        public static void Main()
        {
            int queriesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < queriesCount; i++)
            {
                int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int firstCatLocation = query[0];
                int secondCatLocation = query[1];
                int mouseLocation = query[2];

                AnswerOfQuery(firstCatLocation, secondCatLocation, mouseLocation);
            }
        }
    }
}
