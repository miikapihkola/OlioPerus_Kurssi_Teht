using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht2_Vehicle
{
    internal class Vehicle
    {
        // Field
        protected string make;
        protected string model;
        protected int modelYear;
        protected double price;

        // Constructors
        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        //Methods
        public virtual void PrintInformation()
        {
            Console.WriteLine(  $"  Make:\t{this.make}\n" +
                                $"  Model:\t{this.model}\n" +
                                $"  Model Year:\t{this.modelYear}\n" +
                                $"  Price:\t{this.price}");
        }
    }
}
