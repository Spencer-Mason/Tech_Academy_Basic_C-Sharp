using ConsoleApp1;

// Instantiate class
Class1 class1 = new();

// Ask user to input a number to be divided by two
Console.WriteLine("Please enter a number to divide it by 2:");
// Convert user input from string to int to be used in math operations
int userNumber = Convert.ToInt32(Console.ReadLine());

// Declare result variable to store the output from the method
int result;
// Call method, passing in user input, outputing the result
class1.Method1(userNumber, out result);

// Display result in console
Console.WriteLine("Your number divided by two: " + result);