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
        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            SetId(id);
            this.price = 0;
        }

        // Method
        private void SetId(object id)
        {
            throw new NotImplementedException();
        }        
    }
}
