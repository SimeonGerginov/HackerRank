using System;

namespace TimeConversion
{
    public class Startup
    {
        public static void Main()
        {
            string time = Console.ReadLine();
            DateTime timeAsDate = Convert.ToDateTime(time);
            Console.WriteLine(timeAsDate.ToString("HH:mm:ss"));
        }
    }
}
