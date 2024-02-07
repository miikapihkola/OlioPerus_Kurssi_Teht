using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht8_Monikulmiot
{
    internal abstract class Shape : IComparable<Shape>
    {
        // Field
        protected string type;
        protected string color;

        // Constructor
        protected Shape(string type, string color)
        {
            this.type = type;
            this.color = color;
        }

        // Methods
        public abstract double GetArea();
        public abstract string GetInfo();
        public string GetColor() => color;


        // Methods : IComparable

        //public int CompareTo(Shape? other) => GetArea().CompareTo(other?.GetArea());
        public int CompareTo(Shape? other) => color.CompareTo(other?.color);
    }
}
