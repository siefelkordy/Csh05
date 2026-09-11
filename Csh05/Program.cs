namespace Csh05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C#Basics-04 Assignment 
            #region
            //1st answer
            double[] prices = new double[3];
            prices[0] = 25.5;
            prices[1] = 40;
            prices[2] = 33.75;
            Console.WriteLine(prices[1]);

            #endregion

            #region
            //2nd answer
            int[,] shelfcopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfcopies[1, 0]);
            #endregion

            #region
            //3rd answer
            static void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();
            #endregion

            #region
            //4th answer
            void PrintBook(string title)
            {
                Console.WriteLine("Book title:" + title);
            }
            PrintBook("Clean Code");

            #endregion

            #region 
            //5th answer
            // I expect the value to be 400 as this is passing by value - value type . That doesn't change the value of the variable outside the method.
            int pages = 400;
            void AddPages(int pages)
            {
                pages += 50;
            }
            AddPages(pages);
            Console.WriteLine(pages);
            #endregion
        }
    }
}
