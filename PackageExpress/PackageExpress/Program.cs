// Greets the user with a welcome line
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
// Asks for the package weight
Console.WriteLine("Please enter the package weight.");
int weight = Convert.ToInt16(Console.ReadLine());
// If weight is over 50, program ends
if (weight > 50)
{
    Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
}
// If 50 or less, asks for package dimensions
else
{
    Console.WriteLine("Please enter the package width.");
    int width = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please enter the package height.");
    int height = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Please enter the package length.");
    int length = Convert.ToInt16(Console.ReadLine());
    // If dimensions are too large, program ends
    int dimensions = width + height + length;
    if (dimensions > 50)
    {
        Console.WriteLine("Package too big to be shipped via Package Express.");
    }
    // If dimensions are 50 or less, calculates quote
    else
    {
        int quote = (width * height * length * weight) / 100;
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString());
    }
}