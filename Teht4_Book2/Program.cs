using MyPersonalAdditions;
namespace Teht4_Book2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            Book book1 = new() { name = "Aa", publisher = "PubA", Price = 25, Isbn = "1234567890" };
            Book book2 = new() { name = "Bb", publisher = "PubB", Price = 45, Isbn = "12345" };
            Book book3 = new() { name = "Cc", publisher = "PubA", Price = 30, Isbn = "987654321098765" };
            Book book4 = new() { name = "Dd", publisher = "PubC", Price = 69.99, Isbn = "9781357913579" };
            Book book5 = new() { name = "Ee", publisher = "PubB", Price = 29.99, Isbn = "97813579" };
            Book book6 = new() { name = "Ff", publisher = "PubA", Price = 30.99, Isbn = "978246802468024680" };

            book1.GetBookDetails("9781234567890"); //978 prefix
            book2.GetBookDetails("9781234500000");
            book2.GetBookDetails("134");           

            Book.ChangeTheme();
            Book.ChangeTheme();

            book1.GetBookDetails("9781234567890");
            book2.GetBookDetails("9781234500000");

            Console.WriteLine(book1.Isbn);
            Console.WriteLine(book2.Isbn);
            Console.WriteLine(book3.Isbn);
            Console.WriteLine(book4.Isbn);
            Console.WriteLine(book5.Isbn);
            Console.WriteLine(book6.Isbn);

            PersonalFuncs.EndMeth();
        }
    }
}