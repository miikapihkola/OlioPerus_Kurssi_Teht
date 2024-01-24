using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Teht4_Book2
{
    public class Book
    {
        // Field
        public string name;
        private readonly string author;
        public string publisher;
        private double price;
        private string isbn;
        private static string _theme;

                // for isbn
        private const int MaxLength = 13;
        private const string Prefix = "978";

        // Properties
        public static string Theme { get => _theme; set => _theme = value; }
        public double Price 
        { 
            get => price;
            set 
            {
                this.price = value;
                if (price > 30) this.price *= 0.9;
            }
        }

        public string Isbn
        { 
            get => isbn;
            set
            {
                this.isbn = value;
                if (isbn.Length >= 3)
                {
                    if (isbn[0] != Prefix[0] || isbn[1] != Prefix[1] || isbn[2] != Prefix[2])
                        this.isbn = Prefix + this.isbn;
                }
                else this.isbn = Prefix + this.isbn;
                if (isbn.Length < MaxLength)
                {
                    while (isbn.Length < MaxLength)
                        this.isbn += "0";
                }
                else if (isbn.Length > MaxLength) 
                {
                    this.isbn = this.isbn.Remove(MaxLength);
                }                
            } 
        }

        public string Author { get => author; }

        // Constructor
        public Book() 
        {
            this.name = string.Empty;
            author = "AutA";
            this.publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
            Theme = "Romance";
        }        

        // Methods
        public void GetBookDetails(string isbnNbr)
        {
            if (isbnNbr == this.Isbn)
            {
                Console.WriteLine($"  Book info:\n  Title:\t{this.name}\n  Author:\t{this.Author}\n  Publisher:\t{this.publisher}\n  Price:\t{this.Price:F2} €\n  Theme:\t{Theme}\n");
            }
            else
                Console.WriteLine("  Cannot get book details.\n");
        }
        public static void ChangeTheme()
        {
            Console.WriteLine("  Change Theme:\n  Horror [1],  Fantasy [2],  Romance [3]");
            switch (Console.ReadLine())
            {
                case "1":
                    _theme = "Horror";
                    Confirmation(_theme);
                    break;
                case "2":
                    _theme = "Fantasy";
                    Confirmation(_theme);
                    break;
                case "3":
                    _theme = "Romance";
                    Confirmation(_theme);
                    break;
                default:
                    Console.WriteLine("Invalid input, theme stays unchanged\n");
                    break;
            }
        }
        private static void Confirmation(string theme)
        {
            Console.WriteLine($"  Theme changed to {theme}.\n");
        }

        public override string? ToString()
        {
            return $"  Book info:\n  Title:\t{this.name}\n  Author:\t{this.Author}\n  Publisher:\t{this.publisher}\n  Price:\t{this.Price:F2} €\n  Theme:\t{Theme}\n  ISBN:\t\t{this.Isbn}\n";
        }
    }
}
