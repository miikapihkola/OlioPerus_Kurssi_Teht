using MyPersonalAdditions;

namespace Teht3_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartFunc();

            // Make companies
            Company company420 = new("Aa", "osAA", "000", 156, 30);
            Company company420Copy = new(company420);
            Company company240 = new() { title = "Bb", outcome = 136 ,expense = 40 };
            Company company120 = new() { title = "Cc", outcome = 110, expense = 50 };
            Company company80 = new() { title = "Dd", outcome = 108, expense = 60 };
            Company companyNegDesiN11 = new() { title = "Ee", outcome = 62, expense = 70 };

            // Check copy info
            company420.PrintInfo();
            company420Copy.PrintInfo();

            // Print profit%
            company420.Profit();
            company240.Profit();
            company120.Profit();
            company80.Profit();
            companyNegDesiN11.Profit();


            PersonalFuncs.EndFunc();
        }

    }
}