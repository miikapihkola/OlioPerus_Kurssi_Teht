using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Tank : BaseTank, ITank
    {
        // Field
        private int fluid;
        private int capacity;

        // Properties
        public int Fluid 
        { 
            get => fluid;
            set 
            {
                if (fluid > capacity)
                    fluid = capacity;
                else
                    fluid = value;
            }
        }
        public int Capacity { get => capacity; set => capacity = value; }

        // Constructor
        public Tank(string name, int capacity) : base( name)
        {
            this.Fluid = 0;
            this.Capacity = capacity;
        }

        // Methods - ITank
        public string AddToTank(int amount) 
        {
            if ( amount >= 0)
            {
                if ( amount + this.Fluid >= this.Capacity)
                {
                    amount = this.Capacity - this.Fluid;
                    this.Fluid += amount;
                    return $"  säiliöön {this.Name} lisättiin {amount} yksikköä, säiliö on täynnä";
                }
                else
                {
                    this.Fluid += amount;
                    return $"  säiliöön {this.Name} lisättiin {amount} yksikköä";
                }
            }
            else
            {
                return $"  säiliön {this.Name} tilaa ei muutettu";
            }
        }
        public int GetAmount() => this.Fluid;
        public string RemoveFromTank(int amount) 
        {
            if (amount >= 0)
            {
                if (this.Fluid - amount <= 0)
                {
                    amount = this.Fluid;
                    this.Fluid -= amount;
                    return $"  säiliöön {this.Name} poistettiin {amount} yksikköä, säiliö on tyhjä";
                }
                else
                {
                    this.Fluid -= amount;
                    return $"  säiliöön {this.Name} poistettiin {amount} yksikköä";
                }
            }
            else
            {
                return $"  säiliön {this.Name} tilaa ei muutettu";
            }
        }
        public void ClearTank() 
        { 
            this.Fluid = 0;
            Console.WriteLine($"  säiliö {this.Name} on tyhjennetty");
        }

        // Overrides
        public override string ToString()
        {
            return  $"  säiliö:\t{this.Name}\n" +
                    $"  kapasiteetti:\t{this.Capacity}\n" +
                    $"  nestettä:\t{this.Fluid}\n";
        }
    }
}
