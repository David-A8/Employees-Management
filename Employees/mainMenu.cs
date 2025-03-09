public class MainMenu
{
    public void display()
    {
        employeesList employees = new employeesList();
        employees.loadData();
        string response = "";
        string[] options = { "1", "2", "3", "4", "5" };
        while (response != "5")
        {
            while (options.Contains(response) == false)
            {
                Console.Clear();
                Console.WriteLine("Employee Management System");
                Console.WriteLine("Main Menu:");
                Console.Write("   1. Add new employee" +
                "\n   2. Display employee details\n   3. Display all employees" +
                "\n   4. Edit employee's salary\n   5. Exit\n\nSelect a choice from the menu: ");
                response = Console.ReadLine() ?? String.Empty;
            }

            switch (response)
            {
                case "1":
                    Employee newEmployee = new Employee();
                    newEmployee.newEmployee(employees.empList);
                    employees.AddEmployeeToList(newEmployee);
                    break;
                case "2":
                    employees.DisplayByID();
                    break;
                case "3":
                    employees.DisplayEmployees();
                    break;
                case "4":
                    employees.DisplayByID();
                    break;
                case "5":
                    employees.saveData();
                    Environment.Exit(0);
                    break;
            }
            response = "";
        }
    }
}