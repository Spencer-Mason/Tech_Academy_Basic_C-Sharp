using Lambda;

// List of employees with ID, first name and last name
List<Employee> employees = new()
{
    new Employee { Id = 1, firstName = "Joe", lastName = "Smith" },
    new Employee { Id = 2, firstName = "Joe", lastName = "Doe" },
    new Employee { Id = 3, firstName = "Veronica", lastName = "Corningstone" },
    new Employee { Id = 4, firstName = "Ron", lastName = "Burgundy" },
    new Employee { Id = 5, firstName = "Brick", lastName = "Tamland"},
    new Employee { Id = 6, firstName = "Brian", lastName = "Fantana"},
    new Employee { Id = 7, firstName = "Champ", lastName = "Kind"},
    new Employee { Id = 8, firstName = "Wes", lastName = "Mantooth"},
    new Employee { Id = 9, firstName = "Garth", lastName = "Holliday"},
    new Employee { Id = 10, firstName = "Ed", lastName = "Harken"}
};

// Create a new list to store the Joes from the foreach loop
List<Employee> joes = new();

Console.WriteLine("Joes using foreach loop:");
// Loop through each employee in the list
foreach (Employee emp in employees)
{
    // If first name is equal to "Joe", add it to the list
    if (emp.firstName == "Joe")
    {
        joes.Add(emp);
        Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
    }
}

// Lambda expression that essentially performs the same function as the loop, but in just one line of code
List<Employee> joes2 = employees.Where(x => x.firstName == "Joe").ToList();

// A loop just to print the contents of the list, making sure the lambda expression worked properly
Console.WriteLine("\nJoes using lambda:");
foreach (Employee emp in joes2)
{
    Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
}

Console.WriteLine("\nEmployees with an ID greater than 5:");

// Same as joes2 list, but with employees whose IDs are greater than five, and a loop to print the contents
List<Employee> greaterThanFive = employees.Where(x => x.Id > 5).ToList();
foreach (Employee emp in greaterThanFive)
{
    Console.WriteLine("{0} {1}", emp.firstName, emp.lastName);
}