using MyPersonalAdditions;
using Literature;
namespace Teht5_Author
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            //txt
            const int maxbooks = 6;
            int idCounter = 0;

            Book[] books = new Book[maxbooks];
            books[idCounter++] = new Book() { name = "Aa", publisher = "PubA", Price = 25, Isbn = "1234567890" };
            books[idCounter++] = new Book() { name = "Bb", publisher = "PubB", Price = 45, Isbn = "12345" };
            books[idCounter++] = new Book() { name = "Cc", publisher = "PubA", Price = 30, Isbn = "987654321098765" };
            books[idCounter++] = new Book() { name = "Dd", publisher = "PubC", Price = 69.99, Isbn = "9781357913579" };
            books[idCounter++] = new Book() { name = "Ee", publisher = "PubB", Price = 29.99, Isbn = "97813579" };
            books[idCounter++] = new Book() { name = "Ff", publisher = "PubA", Price = 30.99, Isbn = "978246802468024680" };

            Author aut1 = new() { birthday = "01.01.1990", name = "AutA", Book = books[0] };
            Author aut2 = new() { birthday = "22.02.2000", name = "AutB", Book = books[1] };
            Author aut3 = new() { birthday = "13.03.2003", name = "AutC" };

            aut1.PrintInformation();
            aut2.PrintInformation();
            aut3.PrintInformation();

            PersonalFuncs.EndMeth();
        }
    }
}