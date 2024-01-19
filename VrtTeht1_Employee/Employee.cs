using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrtTeht1_Employee
{
    internal class Employee
    {
        // Field
        public string name;
        private string id;
        public string position;
        public double salary;
        

        // Properties
        public string Id { get => id; }

        // Constructor
        public Employee(int idCounter) 
        {
            this.name = string.Empty;
            AutomaticId(idCounter);
            this.position = string.Empty;
            this.salary = 0;
        }

        // Methods
        public void CompareSalary(Employee employee) 
        {
            if (this.salary > employee.salary) 
                Console.WriteLine($"  {this.position,-17} {"'"+this.name+"'",-15}\tSalary: {this.salary:F2} €\n  has {this.salary-employee.salary:F2} € higher salary than\n  {employee.position,-17} '{employee.name}'\n");
            else if (this.salary < employee.salary)
                Console.WriteLine($"  {this.position,-17} {"'" + this.name + "'",-15}\tSalary: {this.salary:F2} €\n  has {employee.salary - this.salary:F2} € lower salary than\n  {employee.position,-17} '{employee.name}'\n");
            else 
                Console.WriteLine($"  {this.position,-17} '{this.name}' and\n  {employee.position,-17} '{employee.name}'\n  have equal salary of {this.salary:F2} €\n");
        }
        public void PrintEmployeeInfo() 
        {
            Console.WriteLine($"  Name:\t\t{this.name}\n  Id:\t\t{this.Id}\n  Position:\t{this.position}\n  Salary:\t{this.salary:F2} €\n");
        }
        private void AutomaticId(int idCounter)
        {
            id = string.Empty;
            id = idCounter.ToString();
            while (Id.Length < 5) id = "0" + id;
        }
        public override string? ToString()
        {
            return $"  Name:\t\t{this.name}\n  Id:\t\t{this.Id}\n  Position:\t{this.position}\n  Salary:\t{this.salary:F2} €\n";
        }
    }
}
