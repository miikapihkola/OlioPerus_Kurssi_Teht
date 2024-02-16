using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht3_Vakuutukset
{
    public class Insurance
    {
        // Field
        private string species;
        private string name;
        private bool neutered;
        private double fee;

        // Properties
        public string Species => species;
        public string Name => name;
        public bool Neutered => neutered;
        public double Fee => fee;

        // Constructor
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }

        // Methods
        public string GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }

        // Overrides
        public override string? ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}
