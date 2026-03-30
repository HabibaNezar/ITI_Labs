namespace lab6_practice_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // focus focus focus
            // book instances
            Book b1 = new Book("1", "book1", new string[] { "auth1", "auth2", "auth3", "auth4" }, new DateTime(2020, 8, 20), 20m);
            Book b2 = new Book("2", "book2", new string[] { "auth1", "auth2", "auth3", "auth4" }, new DateTime(2025, 5, 10), 50m);

            // books list
            List<Book> books = new List<Book>(){ b1,b2,};

            // get title by user defined delegate
            // note that delegate accept method as its parameter 

            BookDelegate bTitle = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, bTitle);// يبقي انا كده بدي للفنكشن delegte which have the method i want to pass as a parameter

            // base class library delegate (func)
            Func<Book, string> auths = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, auths);

            //  Anonymous Method (GetISBN) 
            LibraryEngine.ProcessBooks(books,(BookDelegate)delegate (Book B){return B.ISBN;});

            //  Lambda Expression (GetPublicationDate)
            LibraryEngine.ProcessBooks(books, (Func<Book, string>) (b => b.PublicationDate.ToShortDateString()));

        }
    }
}
