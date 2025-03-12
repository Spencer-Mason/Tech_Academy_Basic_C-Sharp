using OverloadOperators;

// Creating employee objects
Employee emp1 = new Employee { Id = 1, FirstName = "Spencer", LastName = "Mason" };
Employee emp2 = new Employee { Id = 1, FirstName = "Mos", LastName = "Mason" };
Employee emp3 = new Employee { Id = 3, FirstName = "Tenebris", LastName = "Cat" };

// Compare employees using overloaded operators
// Equal to
Console.WriteLine("Employee one and two have the same ID? " + (emp1 == emp2));
Console.WriteLine("Employee one and three have the same ID? " + (emp1 == emp3));
// Not equal to
Console.WriteLine("Employee one and two have different IDs? " + (emp1 != emp2));
Console.WriteLine("Employee two and three have different IDs? " + (emp2 != emp3));