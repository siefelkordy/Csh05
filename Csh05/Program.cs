using System.Runtime.InteropServices;

namespace Csh05
{
    #region
    //C#Basics-05 (Access Modifiers) 1st answer
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string Title;
        public enum Genre
        {
            Fiction,
            NonFiction,
            Science
        };
    }
    #endregion


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

            #region
            //6th answer
            // I expect the value to be 20.5 and to be modified as this passing by value - reference type. That changes the value of the variable outside the method.
            void ApplyDiscount(double[] prices)
            {
                prices[0] -= 5;
            }
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]);
            #endregion

            #region
            //7th answer
            // I expect here the value to be changed as this is passing value by reference type. This will change the value of the variable outside the method.
            void AddBonusPagesByRef(ref int pages)
            {
                pages += 50;
            }
            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);

            #endregion

            #region
            //8th answer
            void ReplaceArray(ref double[] prices)
            {
                prices[0] = 10.0;
                prices[1] = 12.5;
                prices[2] = 15.0;

            }
            ReplaceArray(ref prices);
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine(prices[i]);
            }
            ;


            #endregion

            #region
            //C#Basics-05 1st answer
            bool TryGetPrice(string title, out double price)
            {
                if (title == "Clean Code")
                {
                    price = 25.5;
                    return true;
                }
                else
                {
                    price = 0;
                    return false;

                }
            }
            Console.WriteLine(TryGetPrice("Clean Code", out double price));
            Console.WriteLine(price);
            #endregion

            #region
            //C#Basics-05 2nd answer
            void PrintBookInfo(string title, int pages = 300)
            {
                Console.WriteLine($"Book title: {title}, Pages: {pages}");
            }
            PrintBookInfo("Clean Code");
            PrintBookInfo("Clean Code", 200);

            #endregion

            #region
            //C#Basics-05 3rd answer
            PrintBookInfo(pages: 500, title: "Clean Code");
            #endregion

            #region
            //C#Basics-05 4th answer
            void PrintAllTitles(params string[] titles)
            {
                for (int i = 0; i < titles.Length; i++)
                {
                    Console.WriteLine(titles[i]);
                }
            }
            PrintAllTitles("Title1", "Title2", "Title3");

            #endregion

            #region
            //C#Basics-05 (Access Modifiers) 1st answer calling
            Book b = new Book();
            //Console.WriteLine(b.password); It doesnt compile as password is private and cant be accessed in another class
            //C#Basics-05 (Access Modifiers) 2nd answer calling
            Console.WriteLine(b.copiesInStock);//It compiles as copiesInStock is internal and can be accessed in any other class in the same folder
            //C#Basics-05 (Access Modifiers) 3rd answer calling
            b.Title = "Salma";
            Console.WriteLine(b.Title);
            #endregion
            //C#Basics-05 (Access Modifiers) 4th answer 
            Book.Genre genre = Book.Genre.Science;
            Console.WriteLine(Enum.TryParse(genre.ToString(),true, out Book.Genre parsedGenre));
            Console.WriteLine(parsedGenre);





        }

    }
}
