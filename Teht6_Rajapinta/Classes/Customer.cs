using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht6_Rajapinta.Interfaces;

namespace Teht6_Rajapinta.Classes
{
    internal class Customer : ICustomer
    {
        // Field
        public string name;
        public List<Product> products;

        // Constructor
        public Customer(string name, List<Product> products)
        {
            this.name = name;
            this.products = products;
        }

        // Methods : ICustomer
        public double GetBonus()
        {
            double total = 0;
            foreach (Product product in products)
                total += product.CalculateTotal();
            if (total <= 1000) return total * 0.02;
            else if (total <= 2000) return total * 0.03;
            else return total * 0.05;
        }

        public Customer? GetCustomer(string name)
        {
            if (this.name.ToLower().Replace(" ", "").Contains(name.ToLower().Replace(" ", ""))) return this;
            return null;
        }

        // Overrides
        public override string? ToString()
        {
            double total = 0;
            int itemTotal = 0;
            foreach (Product product in products)
            {
                total += product.CalculateTotal();
                itemTotal += product.count;
            }
            return $"  Customer:\t{name}\n" +
                    $"  Diff items:\t{products.Count}\n" +
                    $"  Total items:\t{itemTotal}\n" +
                    $"  Total cost:\t{total:F2} €\n";
        }
    }
}
