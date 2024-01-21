using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht1_Book;

namespace Teht1_Book
{
    internal class Book
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

        public override string? ToString()
        {
            return $"{this.title}, {this.author}, {this.id}, {this.price}";
        }
    }
}
