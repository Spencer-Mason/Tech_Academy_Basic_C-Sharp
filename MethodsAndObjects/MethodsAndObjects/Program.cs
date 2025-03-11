using MethodsAndObjects;

// Instantiate class
Employee employee = new();

// Access inherited properties and method
employee.FirstName = "Sample";
employee.LastName = "Student";
employee.SayName();

// Use polymorphism; Employee object is assigned to an IQuittable reference
IQuittable employeeQuit = employee;

// Calling the Quit method
employeeQuit.Quit();