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
}