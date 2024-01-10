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
        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            SetId(id);
            this.price = price;
        }

        // Method
        private void SetId(object id)
        {
            
        }        
    }
}
