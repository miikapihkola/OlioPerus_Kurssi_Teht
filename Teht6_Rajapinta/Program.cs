using MyPersonalAdditions;
using Teht6_Rajapinta.Interfaces;
namespace Teht6_Rajapinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();
            // -----  -----
            // ----- Generate product lists -----

            List<Product> products = new()
            {
                new("Prod1", 11.11, 11),
                new("Prod2", 22.22, 22),
                new("Prod3", 33.33, 33)
            };
            // Vaihtoehtonen tapa lisätä            
            products.Add(new("Prod4", 44.44, 44));
            products.Add(new("Prod5", 55.55, 55));

            List<Product> order1 = new()
            {
                new("Prod1", 11.11, 11),
                new("Prod2", 22.22, 22)
            };

            List<Product> order2 = new()
            {
                new("Prod1", 11.11, 11),
                new("Prod2", 22.22, 22),
                new("Prod3", 33.33, 33)
            };

            List<Product> order3 = new()
            {
                new("Prod1", 11.11, 11),
                new("Prod2", 22.22, 22),
                new("Prod3", 33.33, 33),
                new("Prod4", 44.44, 44)
            };

            // ----- Generate Customers -----

            List<Customer> customers = new()
            {
                new("Aa Aa", order1),
                new("Bb Bb", order2),
                new("Cc Cc", order3)
            };

            // ----- Generate Stores -----

            List<Store> stores = new()
            {
                new("Abcde", 100000),
                new("Fghij", 20000)
            };

            // ----- Try Product Methods -----

            PersonalFuncs.PrintLine();
            foreach (Product product in products)
                Console.WriteLine(product.ToString());

            PersonalFuncs.PrintLine();            
            FindProduct(products, "  pr OD     3  ");
            FindProduct(products, "  D5");

            // ----- Try Customer Methods -----

            PersonalFuncs.PrintLine();
            foreach (Customer customer in customers)
                Console.WriteLine(customer.ToString());

            PersonalFuncs.PrintLine();
            FindCustomer(customers, "  aaa   a  ");
            FindCustomer(customers, "b");
            FindCustomer(customers, "c");

            // ----- Try Store Methods -----

            PersonalFuncs.PrintLine();
            foreach (Store store in stores)
                Console.WriteLine(store.ToString());

            foreach (Store store in stores)
            {
                if (store.GetStore("a") != null)
                {
                    foreach (Product product in products)
                        store.AddProduct(product);
                    foreach (Customer customer in customers)
                        store.AddCustomer(customer);
                }
            }

            foreach (Store store in stores)
            {
                if (store.GetStore("h") != null)
                {
                    store.AddProduct(products[0]);
                    store.AddProduct(products[3]);
                    store.AddProduct(products[4]);
                    store.AddCustomer(customers[0]);
                    store.AddCustomer(customers[2]);
                }
            }
            
            foreach (Store store in stores)
            {
                PersonalFuncs.PrintLine();
                PersonalFuncs.PrintLine();
                Console.WriteLine(store.ToString());
                store.PrintCustomers();
                store.PrintProducts();
            }



            PersonalFuncs.PrintLine();
            PersonalFuncs.EndMeth();
        }
        private static void FindProduct(List<Product> products, string txt) 
        {
            foreach (Product product in products)
            {
                if (product.GetProduct(txt) != null)
                    Console.WriteLine(  $"  Found item...\n{product.ToString()}" +
                                        $"  Total cost:\t{product.CalculateTotal():F2} €\n");
            }
        }
        private static void FindCustomer(List<Customer> customers, string txt)
        {
            foreach (Customer customer in customers)
            {
                if (customer.GetCustomer(txt) != null)
                    Console.WriteLine(  $"  Found Customer...\n{customer.ToString()}" +
                                        $"  Total bonus:\t{customer.GetBonus():F2} €\n");
            }
        }
    }
}
