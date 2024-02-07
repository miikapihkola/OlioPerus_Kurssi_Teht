using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht8_Monikulmiot
{
    internal class Triangle : Shape
    {
        // Field
        private double lenght;
        private double width;

        // Properties
        public double Lenght { get => lenght; set => lenght = value; }
        public double Width { get => width; set => width = value; }

        // Constructor
        public Triangle(string color, double lenght, double width) : base("Triangle", color)
        {
            this.Lenght = lenght;
            this.Width = width;
        }

        // Methods : Shape
        public override double GetArea() => lenght * width / 2;

        public override string GetInfo() => $"  Shape:\t{this.type}\n" +
                                            $"  Color:\t{this.color}\n" +
                                            $"  Lenght:\t{this.Lenght:F2}\n" +
                                            $"  Width:\t{this.Width:F2}\n" +
                                            $"  Area:\t\t{GetArea():F2}\n";
    }
}
