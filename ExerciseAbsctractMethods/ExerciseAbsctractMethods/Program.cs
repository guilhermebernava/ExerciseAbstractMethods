using System;
using System.Collections.Generic;
using System.Linq;
using ExerciseAbsctractMethods.Entities;
using ExerciseAbsctractMethods.Entities.Enum;

namespace ExerciseAbsctractMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.Write("Enter the number of tax payers: ");
            int n = Int32.Parse(Console.ReadLine());
            #region FOR
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company? ");
                TypeTax type = Enum.Parse<TypeTax>(Console.ReadLine());

                switch (type)
                {
                    case 0:
                        PhysicalPerson physicalPerson = new PhysicalPerson();
                        Console.Write("Name: ");
                        physicalPerson.Name = Console.ReadLine();
                        Console.Write("Anual Income: ");
                        physicalPerson.Tax = double.Parse(Console.ReadLine());
                        Console.Write("Health Insurance: ");
                        physicalPerson.HealthInsurance = double.Parse(Console.ReadLine());
                        physicalPerson.ImpostoCalculator();
                        list.Add(physicalPerson);
                        break;
                    case (TypeTax)1:
                        
                        LegalPerson legalPerson = new LegalPerson();
                        Console.Write("Name: ");
                        legalPerson.Name = Console.ReadLine();
                        Console.Write("Anual Income: ");
                        legalPerson.Tax = double.Parse(Console.ReadLine());
                        Console.Write("Number of employees: ");
                        legalPerson.Employees = Int32.Parse(Console.ReadLine());
                        legalPerson.ImpostoCalculator();
                        list.Add(legalPerson);
                        break;
                }
            }
            #endregion //End For

            double total = list.Where(c => c.Tax > 0).Sum(c => c.Tax);
            Console.WriteLine();
            #region Last Print
            Console.WriteLine("TAXES PAID:");   
            foreach(Person person in list)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${total}");
            #endregion // End of the Program
        }
    }
}
