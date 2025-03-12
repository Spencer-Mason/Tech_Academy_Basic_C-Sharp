using ParsingEnums;

// Ask user for day of the week
Console.WriteLine("Please enter a day of the week:");
string day = Console.ReadLine();

// Using a try/catch block in case user input is invalid
try
{
    // Make sure just the first letter of user input is capitalized
    day = char.ToUpper(day[0]) + day.Substring(1).ToLower();
    Days.DaysOfWeek parseDay = (Days.DaysOfWeek)Enum.Parse(typeof(Days.DaysOfWeek), day);
    Console.WriteLine("You entered: " + parseDay);
}
catch (Exception)
{
    // Error message if any ecxeptions are thrown
    Console.WriteLine("Please enter an actual day of the week.");
}