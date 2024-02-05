using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht1_Book;

namespace Teht1_Book
{
    public class Book : IComparable<Book> // For "Teht7" added IComparable and changed to public
    {
        // Field
        public string title;
        public string author;
        public string id;
        public double price;

        // Constructor
        public Book(string title, string author, int idCounter, double price)
        {
            this.title = title;
            this.author = author;
            SetId(idCounter);
            this.price = price;
        }

        // Methods
        public void SetId(int idCounter)
        {
            id = Convert.ToString(idCounter);

            if (id.Length < 5)             
                while (id.Length < 5) id = "0" + id; 
            
            else if (id.Length > 5) 
                id = "XXXXX";
        }
        public string CompareBookPrices(Book book)
        {
            if (book.price > this.price)
                return book.title + " is more expensive.";
            else if (book.price < this.price)
                return this.title + " is more expensive.";
            else return "Both books have same price.";
        }
        public void PrintBookInfo()
        {
            Console.WriteLine("  Title:\t{0}\n  Author:\t{1}\n  Price:\t{2} €\n  Inventory Id:\t{3}\n", this.title, this.author, this.price, this.id);
        }

        // Min to Max
        public int CompareTo(Book? book) // Added during "Teht7"
        {
            return price.CompareTo(book?.price);
        }
        /*
        // Max to Min
        public int CompareTo(Book? book)
        {
            return book.price.CompareTo(price);
        }
        */

        public override string? ToString() // During "Teht7" refactored
        {
            return  $"  Title:\t{this.title}\n" +
                    $"  Author:\t{this.author}\n" +
                    $"  Id:\t\t{this.id}\n" +
                    $"  Price:\t{this.price} €\n";
        }
    }
}
