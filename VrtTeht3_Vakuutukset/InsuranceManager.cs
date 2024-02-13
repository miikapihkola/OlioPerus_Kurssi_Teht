using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht3_Vakuutukset
{
    public class InsuranceManager
    {
        // Field
        public List<Insurance> insurances = new();

        // Methods
        public void AddInsurance(string animal, string name, bool isNeutered)
        {
            insurances.Add(new(animal, name, isNeutered, GetFee(animal, isNeutered)));
        }

        public double GetFee(string species, bool isNeutererd)
        {
            if (species.ToLower() == "koira")
            {
                if (isNeutererd)
                    return 50;
                else
                    return 80;
            }
            else if (species.ToLower() == "kissa")
            {
                if (isNeutererd)
                    return 40;
                else
                    return 60;
            }
            else return 0;
        }

        public void PrintInsurances()
        {
            Console.WriteLine($"vakuutuksia yhteensä {insurances?.Count}\n\nvakuutukset:\n");
            insurances?.ForEach(delegate
            {
                Console.WriteLine("  " + this.ToString() + "\n"); // EI TOIMI
            });
        }

        public void FindInsurances(string species, bool isNeutered)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\nlöytyi:\n");
            insurances?.ForEach(delegate
            {
                
            });
        }
    }
}
