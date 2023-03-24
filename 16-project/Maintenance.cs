namespace _16_project
{
    public class Maintenance : Employee
    {
        public Maintenance(int id, string name, decimal loggedHours, decimal wage): base( id, name, loggedHours, wage) 
        { }
        private const decimal HardShip = 100m;
        protected override decimal Calculate()
        {
            return base.Calculate() + HardShip;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nHardShip: ${Math.Round(HardShip, 2):N0}" +
                $"\nNet Salary: ${Math.Round(Calculate(), 2):N0}";
        }
    }
}