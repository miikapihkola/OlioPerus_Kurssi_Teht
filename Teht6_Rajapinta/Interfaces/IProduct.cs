using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht6_Rajapinta.Classes;

namespace Teht6_Rajapinta.Interfaces
{
    internal interface IProduct
    {
        // Methods
        Product? GetProduct(string name);

        double CalculateTotal();
    }
}
