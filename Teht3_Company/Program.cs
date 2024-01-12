﻿using MyPersonalAdditions;

namespace Teht3_Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.startFunc();

            // Make companies
            Company company420 = new("Aa", "osAA", "000", 156, 30);
            Company company420Copy = new(company420);
            Company company240 = new(); company240.title = "Bb"; company240.outcome = 136; company240.expense = 40;           
            Company company120 = new(); company120.title = "Cc"; company120.outcome = 110; company120.expense = 50;
            Company company80 = new(); company80.title = "Dd"; company80.outcome = 108; company80.expense = 60;
            Company companyNegDesiN11 = new(); companyNegDesiN11.title = "Ee"; companyNegDesiN11.outcome = 62; companyNegDesiN11.expense = 70;

            // Check copy info
            company420.printInfo();
            company420Copy.printInfo();

            // Print profit%
            company420.profit();
            company240.profit();
            company120.profit();
            company80.profit();
            companyNegDesiN11.profit();


            PersonalFuncs.endFunc();
        }

    }
}