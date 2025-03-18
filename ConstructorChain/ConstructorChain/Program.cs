using ConstructorChain;

// Create and print a constant greeting variable
const string greeting = "Welcome to the Multiply Two Numbers Application!";
Console.WriteLine(greeting);

// Ask for user name input optionally
Console.WriteLine("Enter your name, or don't.");
var name = Console.ReadLine();
// Ask for a number to multiply
Console.WriteLine("Enter a number to multiply(required)");
// Define an int variable for TryParse method
int number;
// Keeps asking for input as long as user input is not a valid number
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Please enter a valid number:");
}
// Ask for an optional second number to multiply
Console.WriteLine("Enter another number, or press enter to use default 2");
var input = Console.ReadLine();
// Define the mult variable for another TryParse
int mult;
// If TryParse is succeessful, update mult value with user input and set hasMult to true
// If not successful, hasMult is false and mult is not used
bool hasMult = int.TryParse(input, out mult);

// Ternary operator with nested ternary operators to determine what arguments are passed to the class
// based on if user input a name and/or a multiplier
Class1 user = string.IsNullOrWhiteSpace(name)
    ? (hasMult ? new(number, mult) : new(number))
    : (hasMult ? new(name, number, mult) : new(number));