public class MainMenu
{
    public void display()
    {
        employeesList employees = new employeesList(); //Creates an employees object which manages everything related to employees
        employees.loadData(); // Calls loadData function from employees to load saved data in local file
        string response = "";
        string[] options = { "1", "2", "3", "4", "5" };
        while (response != "5")
        {
            while (options.Contains(response) == false)
            {
                Console.Clear(); // Clears the console
                Console.WriteLine("Employee Management System"); // Displays menu options
                Console.WriteLine("Main Menu:");
                Console.Write("   1. Add new employee" +
                "\n   2. Display employee details\n   3. Display all employees" +
                "\n   4. Edit employee's salary\n   5. Exit\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty; // Catches the user's input
            }

            switch (response)
            {
                case "1":
                    Employee newEmployee = new Employee(); // Creates a new employee object 
                    newEmployee.newEmployee(employees.empList); // Gets the new employee's data
                    employees.AddEmployeeToList(newEmployee); // Adds the new employee to the list of employees
                    break;
                case "2":
                    employees.DisplayByID();
                    break;
                case "3":
                    employees.DisplayEmployees();
                    break;
                case "4":
                    employees.editSalary();
                    break;
                case "5":
                    employees.saveData(); // Save all the data in a local file
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}