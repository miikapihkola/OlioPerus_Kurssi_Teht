using MyPersonalAdditions;
using Teht1_Book;

namespace Teht7_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();
            PersonalFuncs.PrintLine();

            int idCounter = 0;
            List<Book> bookList = new() 
            { 
                new("Title1", "Aut1", idCounter++, 11.11),
                new("Title2", "Aut2", idCounter++, 22.22),
                new("Title3", "Aut1", idCounter++, 22.22),
                new("Title4", "Aut3", idCounter++, 11.11),
                new("Title5", "Aut2", idCounter++, 33.33)
            };

            bookList.Sort();
            foreach (Book book in bookList)
            {
                Console.WriteLine(book);
            }

            PersonalFuncs.PrintLine();
            PersonalFuncs.EndMeth();
        }
    }
}
