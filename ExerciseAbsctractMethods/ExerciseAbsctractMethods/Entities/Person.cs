namespace ExerciseAbsctractMethods.Entities
{
    abstract class Person
    {
        public double Tax { get; set; }
        public string Name { get; set; }

        public Person() { }

        public Person(double tax, string name)
        {
            Tax = tax;
            Name = name;
        }

        public abstract void ImpostoCalculator();
    }
}
