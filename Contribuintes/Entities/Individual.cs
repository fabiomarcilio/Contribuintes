

namespace Contribuintes.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            
            return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
        }

    }
}
