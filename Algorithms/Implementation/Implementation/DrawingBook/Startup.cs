namespace DrawingBook
{
    using System;

    public class Startup
    {
        private static int MinNumberOfPagesToTurn(int numberOfPages, int page)
        {
            if (page % 2 == 0 && page + 1 == numberOfPages)
            {
                return 0;
            }
            else if (page != 1 && page % 2 != 0 && page + 1 == numberOfPages)
            {
                return 1;
            }

            int countFromPageOne = 0;
            int countFromLastPage = 0;
            int temporaryPage = page;

            while (true)
            {
                if (temporaryPage <= 1)
                {
                    break;
                }

                countFromPageOne++;
                temporaryPage -= 2;
            }

            while (true)
            {
                if(numberOfPages - 1 <= page)
                {
                    break;
                }

                countFromLastPage++;
                numberOfPages -= 2;
            }

            return Math.Min(countFromPageOne, countFromLastPage);
        }

        public static void Main()
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int page = int.Parse(Console.ReadLine());

            int minNumberOfPagesToTurn = MinNumberOfPagesToTurn(numberOfPages, page);
            Console.WriteLine(minNumberOfPagesToTurn);
        }
    }
}
