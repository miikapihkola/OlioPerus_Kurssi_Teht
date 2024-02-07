using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht3_Vakuutukset
{
    public class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }
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
        public override string? ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}
