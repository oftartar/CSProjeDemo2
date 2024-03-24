namespace CSProjeDemo2
{
    public class Manager : Employee
    {
        double hourlyWage;
        public override double HourlyWage
        {
            get { return hourlyWage; }
            set { hourlyWage = value > 500 ? value : 500; }
        }
        public override double CalculateSalary(out double bonusSalary)
        {
            bonusSalary = BonusSalary;
            if (HourlyWage <= 500) return 0;

            return WorkHours * HourlyWage;
        }
    }
}
