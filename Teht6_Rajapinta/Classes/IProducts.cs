using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teht6_Rajapinta.Interfaces;

namespace Teht6_Rajapinta.Classes
{
    internal interface IProducts
    {
        // Methods
        void AddProduct(Product product);
        void PrintProducts();
    }
}
