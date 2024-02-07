using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht8_Monikulmiot
{
    internal class Circle : Shape
    {
        // Field
        private double radius;

        // Properties
        public double Radius { get => radius; set => radius = value; }

        // Constructor
        public Circle(string color, double radius) : base("Circle", color)
        {
            this.Radius = radius;
        }

        // Methods : Shape
        public override double GetArea() => double.Pi * Math.Pow(radius, 2);

        public override string GetInfo() => $"  Shape:\t{this.type}\n" +
                                            $"  Color:\t{this.color}\n" +
                                            $"  Radius:\t{this.Radius:F2}\n" +
                                            $"  Area:\t\t{GetArea():F2}\n";
    }
}
