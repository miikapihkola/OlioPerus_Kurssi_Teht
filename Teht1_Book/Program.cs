using MyPersonalAdditions;
namespace Teht1_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.startFunc();

            int idCounter = 0;            

            // ## ALTERNATIVE ## IF no overload
            // Book book1 = new Book();
            // book1.title = "Book1";
            // book1.author = "Auth1";
            // book1.price = 24.99;

            // Create books
            Book book1 = new("Book_A", "Auth_1", idCounter++, 24.99);
            Book book2 = new("Book_B", "Auth_2", idCounter++, 49.99);
            Book book3 = new("Book_C", "Auth_1", idCounter++, 19.99);

            // Retrieve info
            Console.WriteLine();
            printBookInfo(book1);
            printBookInfo(book2);
            printBookInfo(book3);

            // Price Comparison
            printMoreExpensiveBook(book1, book2);
            printMoreExpensiveBook(book2, book3);
            printMoreExpensiveBook(book3, book1);

            
            PersonalFuncs.endFunc();
        }
        // Piti lisätä "static" jotta homma toimii. mitä se tekee?, ilmetteesti ei tossa methodissa ei voi käyttää "new" 
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
        public static void printBookInfo(Book book)
        {
            Console.WriteLine("  Title:\t{0}\n  Author:\t{1}\n  Price:\t{2} €\n  Inventory Id:\t{3}\n", book.title, book.author, book.price, book.id);
        }
        public static void printMoreExpensiveBook(Book book1, Book book2)
        {
            Console.WriteLine("  Comparing following books | {0} || {1} |", book1.title, book2.title);
            Console.WriteLine("  {0}\n", book1.compareBookPrices(book2));
        }
    }
}