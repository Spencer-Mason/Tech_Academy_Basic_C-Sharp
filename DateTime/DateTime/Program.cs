// First print the current date/time
Console.WriteLine("The current date/time is: " + DateTime.Now);
// Ask user to input a number of hours
Console.WriteLine("Please enter a number of hours to add to the current time:");
// Convert user input to an integer and store in a variable
int hours = Convert.ToInt32(Console.ReadLine());
// Add number of hours to current date/time and print result
Console.WriteLine("The date/time in {0} hour will be: {1}", hours, DateTime.Now.AddHours(hours));