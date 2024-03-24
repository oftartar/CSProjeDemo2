using System.Text.Json;

namespace CSProjeDemo2
{
    public class JsonPayrollFormat
    {
        public string Name { get; set; }
        public double WorkHours { get; set; }
        public double MainSalary { get; set; }
        public double BonusSalary { get; set; }
        public double TotalSalary { get; set; }
    }

    public class PayRoll
    {
        public static List<Employee> CreateEmployeesPayRoll(List<Employee> employees)
        {
            List<Employee> employeesWithLowWorkHours = new List<Employee>();
            foreach(Employee employee in employees) 
            {
                if(employee.WorkHours <= 10) employeesWithLowWorkHours.Add(employee);

                double mainSalary = employee.CalculateSalary(out double bonusSalary);

                JsonPayrollFormat data = new JsonPayrollFormat()
                {
                    Name = employee.Name,
                    WorkHours = employee.WorkHours,
                    MainSalary = mainSalary,
                    BonusSalary = bonusSalary,
                    TotalSalary = mainSalary + bonusSalary
                };

                string json = JsonSerializer.Serialize(data);
                string filePath = $"D:\\Projects\\CSProjeDemo2\\CSProjeDemo2\\{employee.Name}\\{DateTime.Now.ToLongDateString()}.json";
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, json);
            }
            return employeesWithLowWorkHours;
        }
    }
}
