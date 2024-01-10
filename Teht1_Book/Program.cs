namespace Teht1_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idCounter = 0;
            string id;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ## ALTERNATIVE ## IF no overload
            // Book book1 = new Book();
            // book1.title = "Book1";
            // book1.author = "Auth1";
            // book1.price = 24.99;

            // Create Book1
            id = idConverter(idCounter++);
            Book book1 = new Book("Book1", "Auth1", id, 24.99);

            // Create Book2
            Book book2 = new Book("Book1", "Auth1", "00002", 49.99);
        }
        public string idConverter(int idCounter)
        {
            string id = Convert.ToString(idCounter++);
            while (id.Length < 5)
            {
                id = "0" + id;
            }
            return id;
        }
    }
}