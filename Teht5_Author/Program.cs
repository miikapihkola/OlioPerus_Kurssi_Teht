using MyPersonalAdditions;
using Teht4_Book2;
namespace Teht5_Author
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            //txt
            Book book1 = new() { name = "Aa", publisher = "PubA", Price = 25, Isbn = "1234567890" };
            Book book2 = new() { name = "Bb", publisher = "PubB", Price = 45, Isbn = "12345" };
            Book book3 = new() { name = "Cc", publisher = "PubA", Price = 30, Isbn = "987654321098765" };
            Book book4 = new() { name = "Dd", publisher = "PubC", Price = 69.99, Isbn = "9781357913579" };
            Book book5 = new() { name = "Ee", publisher = "PubB", Price = 29.99, Isbn = "97813579" };
            Book book6 = new() { name = "Ff", publisher = "PubA", Price = 30.99, Isbn = "978246802468024680" };

            Author aut1 = new() { birthday = "01.01.1990", name = "AutA", Book = book1 };
            Author aut2 = new() { birthday = "22.02.2000", name = "AutB", Book = book2 };

            aut1.PrintInformation();
            aut2.PrintInformation();

            PersonalFuncs.EndMeth();
        }
    }
}