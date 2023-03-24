namespace _16_project
{
    public class Sales : Employee
    {
        public Sales(
            decimal SalesVolume, 
            decimal Commissions, 
            int id, 
            string name, 
            decimal loggedHours, 
            decimal wage
        ) : base(id, name, loggedHours, wage) { }
        private decimal SalesVolume { get; set; }

        private decimal Commissions { get; set; }
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateBonus();
        }

        private decimal CalculateBonus() {
            return SalesVolume * Commissions;
        }

        public override string ToString()
        {
            
            return base.ToString() +
                $"\nCommissions: ${Math.Round(Commissions, 2):N0}" +
                $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                $"\nNet Salary: ${Math.Round(Calculate(), 2):N0}";
        }
    }
}