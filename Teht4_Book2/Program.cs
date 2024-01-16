using MyPersonalAdditions;
namespace Teht4_Book2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartFunc();

            Book book1 = new() { name = "Aa", author = "AutA", publisher = "PubA", Price = 25, Isbn = "01" };
            Book book2 = new() { name = "Bb", author = "AutB", publisher = "PubB", Price = 45, Isbn = "02" };
            book1.GetBookDetails("01");
            book2.GetBookDetails("02");

            Book.ChangeTheme();
            Book.ChangeTheme();

            book1.GetBookDetails("01");
            book2.GetBookDetails("02");

            PersonalFuncs.EndFunc();
        }
    }
}