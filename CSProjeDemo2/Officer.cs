namespace CSProjeDemo2
{
    public class Officer : Employee
    {
        public override double CalculateSalary(out double bonusSalary)
        {
            bonusSalary = 0;
            if (WorkHours <= 180) return WorkHours * HourlyWage;

            bonusSalary = (WorkHours - 180) * 1.5 * HourlyWage;
            return 180 * HourlyWage;
        }
    }
}
