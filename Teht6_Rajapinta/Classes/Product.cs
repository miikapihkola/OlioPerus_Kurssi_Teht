using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht6_Rajapinta.Interfaces;

namespace Teht6_Rajapinta.Classes
{
    internal class Product : IProduct
    {
        // Field
        public string name;
        public double price;
        public int count;

        // Constructor
        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        // Methods : IProduct
        public double CalculateTotal() => price * count;

        public Product? GetProduct(string name)
        {
            if (this.name.ToLower().Replace(" ", "").Contains(name.ToLower().Replace(" ", ""))) return this;
            return null;
        }

        // Overrides
        public override string? ToString()
        {
            return $"  Name:\t\t{name}\n" +
                    $"  Price:\t{price} €\n" +
                    $"  Count:\t{count}\n";
        }
    }
}
