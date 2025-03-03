// List of integers to divide
List<int> numbers = [156, 5, 789, 16865, 213, 105, 12];

// Ask user for a number
Console.WriteLine("Enter a number to divide by:");

// Start try/catch
try
{
    // Convert user input to an integer
    int userNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");
    // Loop through list of numbers and divide each by user's number
    foreach (int number in numbers)
    {
        Console.WriteLine(number + " divided by " + userNumber + " is " + number / userNumber);
    }
}
// If there are any errors, print error's message
catch (Exception ex)
{
    Console.WriteLine("\nError: " + ex.Message);
}

// Continue with code after try/catch block
Console.WriteLine("The program is now continuing with the rest of the code.");