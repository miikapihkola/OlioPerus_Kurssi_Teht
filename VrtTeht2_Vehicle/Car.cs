using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht2_Vehicle
{
    internal class Car : Vehicle
    {
        // Field
        protected string engine;
        protected string type;
        protected int doors;

        // Constructors
        public Car(string engine, string type, int doors, string make, string model, int modelYear, double price) : base(make, model, modelYear, price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        // Methods


        // Overrides
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine(  $"  Engine:\t{this.engine}\n" +
                                $"  Type:\t\t{this.type}\n" +
                                $"  Doors:\t{this.doors}\n");
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override string? ToString()
        {
            return  base.ToString() +
                    $"  Engine:\t{this.engine}\n" +
                    $"  Type:\t\t{this.type}\n" +
                    $"  Doors:\t{this.doors}\n";
        }
    }
}
