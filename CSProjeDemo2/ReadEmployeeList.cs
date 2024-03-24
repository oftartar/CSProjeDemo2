using System.Text.Json;

namespace CSProjeDemo2
{
    public class JsonEmployeeFormat
    {
        public string name { get; set; }
        public string title { get; set; }
    }
    public class ReadEmployeeList
    {
        public static List<Employee> ReadAndCreateEmployeeList(string filePath)
        {
            List<Employee> employees = new List<Employee>();

            List<JsonEmployeeFormat> jsonEmployees = new List<JsonEmployeeFormat>();
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                jsonEmployees = JsonSerializer.Deserialize<List<JsonEmployeeFormat>>(json);
            }

            foreach(JsonEmployeeFormat item in jsonEmployees)
            {
                if(item.title == "Memur")
                {
                    Officer officer = new Officer() 
                    {
                        Id = Guid.NewGuid(),
                        Name = item.name,
                        Title = item.title,
                    };
                    employees.Add(officer);
                }
                if (item.title == "Yonetici")
                {
                    Manager officer = new Manager()
                    {
                        Id = Guid.NewGuid(),
                        Name = item.name,
                        Title = item.title,
                    };
                    employees.Add(officer);
                }
            }

            return employees;
        }
    }
}
