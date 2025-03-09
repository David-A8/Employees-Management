public class Employee
{
    private int employeeId = 0;
    private string name = "";
    private string position = "";
    private float hourlyWage = 0;
    private string email = "";
    private string phone = "";

    public void newEmployee(List<Employee> list)
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

    public void displayEmployee()
    {
        Console.WriteLine($"\nEmployee ID: {employeeId}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Hourly Wate: {hourlyWage}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone Number: {phone}");
    }
}