using System;


namespace ExerciseAbsctractMethods.Entities
{
    internal class PhysicalPerson : Person
    {
        public double HealthInsurance { get; set; }

        public PhysicalPerson() { }

        public PhysicalPerson(double healthInsurance,double Tax, string name) : base(Tax,name) 
        {
            HealthInsurance = healthInsurance;
        }

        public override void ImpostoCalculator()
        { 
            if (HealthInsurance > 0)
            {
                if (Tax < 20000)
                {
                    Tax = (Tax * 0.15) - (HealthInsurance * 0.5);
                    
                }
                else 
                {
                    Tax = (Tax * 0.25) - (HealthInsurance * 0.5);
                    
                }
                
            }
            else
            {
                if (Tax < 20000)
                {
                    Tax = (Tax * 0.15);
                    
                }
               
                {
                    Tax = (Tax * 0.25);
                    
                }
            }
            

                 
        }

        public override string ToString()
        {
            return $"{Name}: ${Tax.ToString("F2")}";
        }
    }
}
