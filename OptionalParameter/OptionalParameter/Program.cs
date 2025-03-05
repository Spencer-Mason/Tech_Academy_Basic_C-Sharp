using OptionalParameter;

// Instantiate class
MathOperation math = new ();

// Ask user for first number input
Console.WriteLine("Enter the first number for a math operation");
int firstNum = Convert.ToInt32(Console.ReadLine());

// Ask user for optional second number
Console.WriteLine("Enter the second number, or just press enter to use default number 2");

// If user entered a number, save it as secondNum and print operation result
if (int.TryParse(Console.ReadLine(), out int secondNum))
{
    int result = math.MathMethod(firstNum, secondNum);
    Console.WriteLine(firstNum + " times " + secondNum + " is: " + result);
}
// If user didn't enter a number, default number is used and print operation result
else
{
    int result = math.MathMethod(firstNum);
    Console.WriteLine(firstNum + " times 2 is: " + result);
}
