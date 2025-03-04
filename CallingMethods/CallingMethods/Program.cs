// Calling the namespace to access the class within
using CallingMethods;

// Ask user to input number
Console.WriteLine("Please enter a number to do some math on.");
int userNum = Convert.ToInt32(Console.ReadLine());

// Call method within writeline, passing it user's input as an argument, to display it's return
Console.WriteLine("Your number plus five is: " + MathsClass.Adding(userNum));
Console.WriteLine("Your number multiplied by 2 is: " + MathsClass.Multiply(userNum));
Console.WriteLine("Your number divided by 2 is: " + MathsClass.Divide(userNum));