// Creating arrays of integers and strings
int[] intArray = new int[] { 19, 42, 69, 420, 666 };
string[] stringArray = new string[] { "yes", "no", "stop", "go", "high", "low", "why", "I don\'t know", "goodbye", "hello" };

// Ask user to specify an index number to get the number at that index
Console.WriteLine("Enter an index number to see the number at that index. Please use 0-4:");
int intNumber = Convert.ToInt32(Console.ReadLine());

// If number is out of range, asks user to enter a valid number
while(intNumber > 4 || intNumber < 0)
{
    Console.WriteLine("There is no number at that index. Please use 0-4.");
    intNumber = Convert.ToInt32(Console.ReadLine());
}

// Displays number at given index
Console.WriteLine("The number at index " + intNumber + " is: " + intArray[intNumber] + "\n\n");

// Ask user to specify an index number to get the string at that index
Console.WriteLine("Enter an index number to see the string at that index. Please use 0-9:");
int stringNumber = Convert.ToInt32(Console.ReadLine());

// If number is out of range, asks user to enter a valid number
while(stringNumber > 9 || stringNumber < 0)
{
    Console.WriteLine("There is no string at that index. Please use 0-9.");
    stringNumber = Convert.ToInt32(Console.ReadLine());
}

// Displays string at given index
Console.WriteLine("The string at index " + stringNumber + " is: \"" + stringArray[stringNumber] + "\"\n\n");

// Create a list of strings
List<string> stringsList = new List<string>
{
    "That", "song", "is", "by", "the", "band", "The Beatles"
};

// Asks user to enter an index number
Console.WriteLine("Enter one last number to see another string. Please use 0-6:");
int listNumber = Convert.ToInt32(Console.ReadLine());

// If number is out of range, asks for a valid number
while(listNumber > 6 || listNumber < 0)
{
    Console.WriteLine("There is no string at that index. Please use 0-6.");
    listNumber = Convert.ToInt32(Console.ReadLine());
}

// Displays string at given index
Console.WriteLine("The string at index " + listNumber + " is: \"" + stringsList[listNumber] + "\"");