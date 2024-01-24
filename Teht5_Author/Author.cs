﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht4_Book2;

namespace Teht5_Author
{
    internal class Author
    {
        // Field
        public string name;
        public string birthday;
        private Book book;

        // Properties
        public Book Book 
        { 
            get => book;
            set
            {
                try
                {
                    if (value.Author == this.name) book = value;
                }
                catch { }
            }
        }

        // Constructor
        public Author()
        {
            this.name = string.Empty;
            this.birthday = string.Empty;
            this.Book = null;
        }
        
        // Methods
        public void PrintInformation()
        {
            Console.WriteLine($"  Author Info:\n  Name:\t\t{this.name}\n  Birthday:\t{this.birthday}\n");
            if (this.book != null) Console.WriteLine($"{ this.Book.ToString()}\n");
            else Console.WriteLine("  This author no books.\n\n");
        }
    }
}
