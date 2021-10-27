using System;

namespace ExerciseAbsctractMethods.Entities
{
    internal class LegalPerson : Person
    {
        public int Employees { get; set; }

        public LegalPerson() { }

        public LegalPerson(int employees,double tax, string name) :base(tax,name) 
        { 
            Employees = employees;
        }

        public override void ImpostoCalculator()
        {
            if (Employees > 10)
            {
                Tax = Tax * 0.14;
            }
            else
            {
                Tax = Tax * 0.16;
            }
        }

        public override string ToString()
        {
            return $"{Name}: ${Tax.ToString("F2")}";
        }
    }
}
