using MyPersonalAdditions;
using Literature;
namespace Teht4_Book2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            const int maxbooks = 6;
            int idCounter = 0;

            Book[] books= new Book[maxbooks];
            books[idCounter++] = new Book() { name = "Aa", publisher = "PubA", Price = 25, Isbn = "1234567890" };
            books[idCounter++] = new Book() { name = "Bb", publisher = "PubB", Price = 45, Isbn = "12345" };
            books[idCounter++] = new Book() { name = "Cc", publisher = "PubA", Price = 30, Isbn = "987654321098765" };
            books[idCounter++] = new Book() { name = "Dd", publisher = "PubC", Price = 69.99, Isbn = "9781357913579" };
            books[idCounter++] = new Book() { name = "Ee", publisher = "PubB", Price = 29.99, Isbn = "97813579" };
            books[idCounter++] = new Book() { name = "Ff", publisher = "PubA", Price = 30.99, Isbn = "978246802468024680" };

            books[0].GetBookDetails("9781234567890"); //978 prefix
            books[1].GetBookDetails("9781234500000");
            books[2].GetBookDetails("134");           

            Book.ChangeTheme();
            Book.ChangeTheme();

            books[0].GetBookDetails("9781234567890");
            books[1].GetBookDetails("9781234500000");

            foreach (Book book in books)
                Console.WriteLine(book.Isbn);


            PersonalFuncs.EndMeth();
        }
    }
}