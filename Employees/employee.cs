public class Employee
{
    private int employeeId = 0;
    private string name = "";
    private string position = "";
    private float hourlyWage = 0;
    private string email = "";
    private string phone = "";

    public void newEmployee(List<Employee> list) // Function to save new employee's data
    {
        employeeId = list.Count + 1;
        Console.Clear();
        Console.WriteLine("New Employee");
        Console.Write("     Name: ");
        name = Console.ReadLine() ?? string.Empty;
        Console.Write("     Position: ");
        position = Console.ReadLine() ?? string.Empty;
        Console.Write("     Hourly Wage: ");
        string wage = Console.ReadLine() ?? string.Empty;
        hourlyWage = float.Parse(wage);
        Console.Write("     Email: ");
        email = Console.ReadLine() ?? string.Empty;
        Console.Write("     Phone Number: ");
        phone = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("New Employee added");
        Thread.Sleep(2000);
    }

    public void displayEmployee() // Function to display employee's data
    {
        Console.WriteLine($"Employee ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Hourly Wage: ${hourlyWage}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone Number: {phone}");
    }

    public int getId()
    {
        return employeeId;
    }

    public void upadteSalary() // Function to update an employee's salary
    {
        Console.WriteLine($"Employee ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Hourly Wate: ${hourlyWage}");
        Console.Write($"\nNew Hourly Wage: ");
        hourlyWage = float.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Salary Updated");
        Thread.Sleep(2000);
    }

    public string ExportTxtData() // Puts all the data in a single line to be saved in local file
    {
        return ($"{employeeId}:/{name}:/{position}:/{hourlyWage}:/{email}:/{phone}");
    }

    public void LoadData(string[] Data) // Gets string data from empoyees list and save the data in variables
    {
        employeeId = int.Parse(Data[0]);
        name = Data[1];
        position = Data[2];
        hourlyWage = float.Parse(Data[3]);
        email = Data[4];
        phone = Data[5];
    }
}