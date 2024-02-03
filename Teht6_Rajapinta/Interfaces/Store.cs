using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht6_Rajapinta.Classes;
using MyPersonalAdditions;

namespace Teht6_Rajapinta.Interfaces
{
    internal class Store : IProducts, ICustomers
    {
        // Field
        public string name;
        public double turnover;
        public List<Product> products;
        public List<Customer> customers;

        // Constructor
        public Store(string name, double turnover)
        {
            this.name = name;
            this.turnover = turnover;
            this.products = new();
            this.customers = new();
        }

        // Methods
        public Store? GetStore(string name)
        {
            if (this.name.ToLower().Replace(" ", "").Contains(name.ToLower().Replace(" ", ""))) return this;
            return null;
        }

        // Methods : IProducts
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void PrintProducts()
        {
            double totPrice = 0;
            double totCount = 0;

            PersonalFuncs.PrintLine();
            Console.WriteLine($"  ----- Store {this.name} has the following Products: ----- \n");
            foreach (Product product in products)
            { 
                Console.WriteLine(product.ToString());
                totPrice += product.CalculateTotal();
                totCount += product.count;
            }
            Console.WriteLine(  $"  ----- Info -----\n\n" +
                                $"  Products:\t{products.Count}\n" +
                                $"  Total Count:\t{totCount}\n" +
                                $"  Total price:\t{totPrice:F2} €\n");
        }

        // Methods : ICustomers
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void PrintCustomers()
        {
            double totBonus = 0;
            double totPrice = 0;
            
            PersonalFuncs.PrintLine();
            Console.WriteLine($"  ----- Store {this.name} has the following Customers: ----- \n");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
                totBonus += customer.GetBonus();
                foreach (Product product in customer.products)
                    totPrice += product.CalculateTotal();
            }
            Console.WriteLine(  $"  ----- Info -----\n\n" +
                                $"  Customers:\t{customers.Count}\n" +
                                $"  Total price:\t{totPrice:F2} €\n" +
                                $"  Total bonus:\t{totBonus:F2} €\n");
        }

        // Overrides
        public override string? ToString()
        {
            return  $"  ----- Store Info -----\n\n" +
                    $"  Name:\t\t{this.name}\n" +
                    $"  Turnover:\t{this.turnover:F2} €\n" +
                    $"  Customers:\t{customers.Count}\n" +
                    $"  Products:\t{products.Count}\n";
        }
    }
}
