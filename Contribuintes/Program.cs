using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> list = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double ai = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, ai, number));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double exp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, ai, exp));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double total = 0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer.Name+": $ "+taxPayer.Tax().ToString("F2",CultureInfo.InvariantCulture));

                total = total + taxPayer.Tax();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ "+total.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
        }
    }
}
