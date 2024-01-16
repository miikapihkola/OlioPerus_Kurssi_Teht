using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht3_Company
{
    internal class Company
    {
        // Field
        public string title;
        public string address;
        public string phone;
        public double outcome;
        public double expense;

        // Constructors
        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }
        public Company(string title, string address, string phone, double outcome, double expense) 
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public Company(Company company)
        {
            this.title = company.title;
            this.address = company.address;
            this.phone = company.phone;
            this.outcome = company.outcome;
            this.expense = company.expense;
        }

        // Methods
        public void Profit()
        {
            double profit = (this.outcome - this.expense) / this.expense * 100;
            string evaluation;

            if (profit < 100) evaluation = "poorly";//"kehnosti";
            else if (profit < 200) evaluation = "tolerably";//"välttävästi";
            else if (profit >= 300) evaluation = "well";//"hyvin";
            else evaluation = "satisfactorily";//"tyydyttävästi";

            Console.WriteLine($"  Company '{this.title}' has profit% of {profit:F2} %.\n  This means it is doing {evaluation}.\n");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"  Title: {this.title}\n  Address: {this.address}\n  Phone #: {this.phone}\n  Outcome: {this.outcome}\n  Expense: {this.expense}\n");
        }
    }
}
