using CSProjeDemo2;

List<Employee> employees = ReadEmployeeList.ReadAndCreateEmployeeList("D:\\Projects\\CSProjeDemo2\\CSProjeDemo2\\data.json");

foreach(Employee employee in employees)
{
    double hourlyWage = 0;
    double workHours = 0;
    double bonusSalary = 0;

    Console.WriteLine($"{employee.Title} {employee.Name} için aylık maaş bilgilerini giriniz: ");
    do 
    {
        Console.WriteLine("\nSaatlik Ücret: ");
    }
    while(!Double.TryParse(Console.ReadLine(), out hourlyWage));
    do
    {
        Console.WriteLine("\nAylık Çalışma Saati: ");
    }
    while (!Double.TryParse(Console.ReadLine(), out workHours));
    if(employee.Title == "Yonetici")
    {
        do
        {
            Console.WriteLine("\nBonus Ücret: ");
        }
        while (!Double.TryParse(Console.ReadLine(), out bonusSalary));
    }
    employee.HourlyWage = hourlyWage;
    employee.WorkHours = workHours;
    employee.BonusSalary = bonusSalary;
}

List<Employee> EmployeesWithLowWorkHours = PayRoll.CreateEmployeesPayRoll(employees);

if(EmployeesWithLowWorkHours.Count > 0)
{
    Console.WriteLine("10 saatten az çalışan personeller: ");
    foreach (Employee employee in EmployeesWithLowWorkHours)
    {
        Console.WriteLine(employee.Name);
    }
}