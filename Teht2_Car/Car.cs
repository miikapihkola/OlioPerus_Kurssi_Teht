using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Teht2_Car;

namespace Teht2_Car
{
    internal class Car
    {
        // Field
        public string brand;
        public double speed;

        // Constructor
        public Car() 
        {
            this.brand = string.Empty;
            this.speed = 0;
        }

        // Methods
        public void AskData()
        {
#pragma warning disable CS8601 // Possible null reference assignment.
            Console.WriteLine("  Enter car brand.");
            this.brand = Console.ReadLine();
            Console.WriteLine("  Enter car speed.");
            if(!double.TryParse(Console.ReadLine(), out this.speed))
            {
                Console.WriteLine("Invalid input, speed was set as 0");
            }            
            if (this.speed < 0)            
                this.speed = -this.speed;            
#pragma warning restore CS8601 // Possible null reference assignment.
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"  Speed of '{this.brand}' is: {this.speed:F0} km/h");
        }
        public void Accelerate(double speedDif)
        {
            if (speedDif < 0)
                speedDif = -speedDif;
            this.speed += speedDif;
        }
        public void Brake()
        {
            this.speed *= 0.9;
        }
    }
}
