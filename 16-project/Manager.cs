namespace _16_project
{
    public class Manager: Employee 
    {
        public Manager(int id, string name, decimal loggedHours, decimal wage):base(id, name, loggedHours, wage) { }
        private const decimal AllowanceRate = 0.05m;
        protected override decimal Calculate()
        {
            return base.Calculate() + CalculateAllowance();
        }

        private decimal CalculateAllowance() {
            return AllowanceRate * base.Calculate();
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nAllowance: ${Math.Round(CalculateAllowance(), 2):N0}"+
                $"\nNet Salary: ${Math.Round(Calculate(), 2):N0}";
        }
    }

}