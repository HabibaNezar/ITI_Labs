namespace day6_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Setup a sample list of books
            List<Book> books = new List<Book>
        {
            new Book("978-0132350884", "Clean Code", new string[] {"Robert C. Martin"}, new DateTime(2008, 8, 1), 45.99m),
            new Book("978-0201633610", "Design Patterns", new string[] {"Erich Gamma", "Richard Helm"}, new DateTime(1994, 10, 31), 54.99m)
        };

            // --- a. User Defined Delegate Datatype ---
            Console.WriteLine("--- A. User Defined Delegate (GetTitle) ---");
            BookDelegate titleDelegate = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, titleDelegate);


            // --- b. BCL Delegates ---
            // Using Func<Book, string> which takes a Book and returns a string
            Console.WriteLine("\n--- B. BCL Delegate (GetAuthors) ---");
            Func<Book, string> authorsDelegate = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, authorsDelegate);


            // --- c. Anonymous Method (GetISBN) ---
            // Inline delegate without a formal method name
            Console.WriteLine("\n--- C. Anonymous Method (GetISBN) ---");
            LibraryEngine.ProcessBooks(books,
             (BookDelegate)delegate (Book B)
             {
                 return B.ISBN;
             });


            // --- d. Lambda Expression (GetPublicationDate) ---
            // The most concise modern approach
            Console.WriteLine("\n--- D. Lambda Expression (GetPublicationDate) ---");
            LibraryEngine.ProcessBooks(books,(Func<Book, string>)(B => B.PublicationDate.ToShortDateString()));
        }
    }
}
