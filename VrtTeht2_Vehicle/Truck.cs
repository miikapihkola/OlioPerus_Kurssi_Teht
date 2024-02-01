using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht2_Vehicle
{
    internal class Truck : Car
    {
        // Field
        private int load;
        private double consumption;


        // Properties
        public int Load { get => load; set => load = value; }
        public double Consumption { get => consumption; set => consumption = value; }


        // Constructor
        public Truck(int load, double consumption, string engine, string type, int doors, string make, string model, int modelYear, double price) 
            : base(engine, type, doors, make, model, modelYear, price)
        {
            this.Load = load;
            this.Consumption = consumption;
        }


        // Methods
        public double CalculateConsumption() => this.Consumption * this.Load;        


        // Overrides
        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine(  $"  Load:\t\t{this.Load} Kg\n" +
                                $"  Consumption:\t{this.Consumption} /Kg\n\n");
        }

        public override string? ToString()
        {
            return  base.ToString() +
                    $"  Load:\t\t{this.Load} Kg\n" +
                    $"  Consumption:\t{this.Consumption} /Kg\n\n";
        }
    }
}
