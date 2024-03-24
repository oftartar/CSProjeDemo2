namespace CSProjeDemo2
{
    abstract public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        virtual public double HourlyWage { get; set; } = 500;
        public double WorkHours { get; set; }
        public double BonusSalary { get; set; }

        abstract public double CalculateSalary(out double bonusSalary);
    }
}
