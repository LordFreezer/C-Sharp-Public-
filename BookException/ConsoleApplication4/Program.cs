using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookExceptionDemo
{
    class BookException : Exception
    {
        private static string message = "  The price of this book is invalid";

        public BookException(string theTitle, double thePrice, int thePages)
            : base(message)
        {
            Console.WriteLine("  The book {0} costs {1} for {2} pages, which is invalid.", theTitle, thePrice.ToString("C2"), thePages);
        }
    }

    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public int pages { get; set; }

        public Book(string Title, string Author, double Price, int Pages)
        {
            title = Title;
            author = Author;
            price = Price;
            pages = Pages;
        }
    }

    public class DemoBooks
    {
        public static void Main()
        {
            Book[] bookArray = new Book[4];

            int y;

            for (y = 0; y < bookArray.Length; ++y)
            {
                bookArray[y] = new Book("x", "x", 2, 2);
            }

            try
            {
                bookArray[0].title = "Shreck"; bookArray[0].author = "Gonzalas, Nick"; bookArray[0].price = 1899; bookArray[0].pages = 254;
                bookArray[1].title = "Shonuff"; bookArray[1].author = "Asian Nick"; bookArray[1].price = 990; bookArray[1].pages = 99;
                bookArray[2].title = "Harabme"; bookArray[2].author = "The other Nick"; bookArray[2].price = 1565; bookArray[2].pages = 175;
                bookArray[3].title = "Life of Trump"; bookArray[3].author = "The Dabbinator"; bookArray[3].price = 299; bookArray[3].pages = 28;

                int x = 0;

                while (x < 4)
                {
                    if ((bookArray[x].pages * 10) < bookArray[x].price)
                    {
                        BookException nbe = new BookException(bookArray[x].title, bookArray[x].price * .01, bookArray[x].pages);
                        throw (nbe);
                    }

                    ++x;
                }

            }

            catch (BookException e)
            {
                Console.WriteLine(e.Message);
            }

            double price1 = bookArray[0].price * .01;
            double price2 = bookArray[1].price * .01;
            double price3 = bookArray[2].price * .01;
            double price4 = bookArray[3].price * .01;

            Console.WriteLine();
            Console.WriteLine("  The book {0} by {1} contains {2} pages and will cost {3}.", bookArray[0].title, bookArray[0].author, bookArray[0].pages, price1.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  The book {0} by {1} contains {2} pages and will cost {3}.", bookArray[1].title, bookArray[1].author, bookArray[1].pages, price2.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  The book {0} by {1} contains {2} pages and will cost {3}.", bookArray[2].title, bookArray[2].author, bookArray[2].pages, price3.ToString("C2"));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("  The book {0} by {1} contains {2} pages and will cost {3}.", bookArray[3].title, bookArray[3].author, bookArray[3].pages, price4.ToString("C2"));

            Console.ReadLine();
        }
    }
}

