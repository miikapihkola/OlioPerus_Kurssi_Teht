using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class BaseTank
    {
        // Field
        private string name;

        // Properties
        protected string Name { get => name; set => name = value; }

        // Constructor
        public BaseTank(string name)
        {
            this.Name = name;
        }
        
        // Overrides
        public override string ToString()
        {
            return Name;
        }
    }
}
