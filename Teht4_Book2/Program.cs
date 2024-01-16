using MyPersonalAdditions;
namespace Teht4_Book2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartFunc();

            Book book1 = new Book(); book1.name = "Aa"; book1.author = "AutA"; book1.publisher = "PubA"; book1.Price = 25; book1.Isbn = "01";
            Book book2 = new Book(); book2.name = "Bb"; book2.author = "AutB"; book2.publisher = "PubB"; book2.Price = 45; book2.Isbn = "02";

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