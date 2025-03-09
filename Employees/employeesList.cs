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
        for (int i = 0; i < empList.Count; i++) // Iterates through Employees list finding an employee that matches the entered ID
        {
            if (empList[i].getId() == int.Parse(id)) // If the ID is found, the displayEmployee function is called
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
            if (empList[i].getId() == int.Parse(id)) // If ID is found, the updateSalary function is called
            {
                empList[i].upadteSalary();
            }
        }
    }

    public void loadData()
    {
        string[] lines = System.IO.File.ReadAllLines("Employees.txt"); // Reads the local text file 
        foreach(string line in lines) // Iterates through each line in the text file
        {
            string[] parts = line.Split(":/"); // Separates the data contained in text file
            empList.Add(new Employee()); // Creates a new employee object and adds it to the employees list
            empList[empList.Count-1].LoadData(parts); // Sends string data to be stored in employee's variables
        }
    }

    public void saveData()
    {
        using (StreamWriter outputFile = new StreamWriter("Employees.txt")) // Creates a text file
        {
            for (int i = 0; i < empList.Count; i++) // Iterates through employees list 
            {
                outputFile.WriteLine(empList[i].ExportTxtData()); // String data is collected from each employee in the employees list
            }
        }
    }
}