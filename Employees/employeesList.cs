public class employeesList
{
    public List<Employee> empList = new List<Employee>(); // Creates a list to store employees

    public void DisplayEmployees() // Function to display all employees
    {
        Console.Clear();
        Console.WriteLine("List of Employees");
        for (int i = 0; i < empList.Count; i++) //Iterates through the employees list
        {
            empList[i].displayEmployee(); // Calls the display function for each employee
            Console.WriteLine($"--------------------------------------------------------------------------\n");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(); // Waits for a key press
    }

    public void AddEmployeeToList(Employee newEmployee) // Function to add a new employee
    {
        empList.Add(newEmployee); // Adds a new employee to the employees list
    }

    public void DisplayByID()
    {
        Console.Clear();
        Console.WriteLine("Employee Details");
        Console.Write("\nEnter Employee ID: ");
        string id = Console.ReadLine() ?? string.Empty;
        for (int i = 0; i < empList.Count; i++)
        {
            if (empList[i].getId() == int.Parse(id))
            {
                empList[i].displayEmployee();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); // Waits for a key press
            }
        }
    }

    public void editSalary()
    {
        Console.Clear();
        Console.WriteLine("Edit Employee's Salary");
        Console.Write("\nEnter Employee ID: ");
        string id = Console.ReadLine() ?? string.Empty;
        for (int i = 0; i < empList.Count; i++)
        {
            if (empList[i].getId() == int.Parse(id))
            {
                empList[i].upadteSalary();
            }
        }
    }

    public void loadData()
    {
        string[] lines = System.IO.File.ReadAllLines("Employees.txt");
        foreach(string line in lines)
        {
            string[] parts = line.Split(":/");
            empList.Add(new Employee());
            empList[empList.Count-1].LoadData(parts);
        }
    }

    public void saveData()
    {
        using (StreamWriter outputFile = new StreamWriter("Employees.txt"))
        {
            for (int i = 0; i < empList.Count; i++)
            {
                outputFile.WriteLine(empList[i].ExportTxtData());
            }
        }
    }
}