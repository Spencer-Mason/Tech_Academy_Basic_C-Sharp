using AbstractClass;

// Instantiate class and set name values
Employee employee = new() { FirstName = "Sample", LastName = "Student" };

// Calling method to print name to console
employee.SayName();

// Using polymorphism; Employee object assigned to an IQuittable reference
IQuittable quittable = employee;

// Calling method to print quit message to console
quittable.Quit();