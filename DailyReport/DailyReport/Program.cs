// Writes introductory lines to the console
Console.WriteLine("The Tech Academy.");
Console.WriteLine("Student Daily Report.");

// Asks the students name and saves the response as a string
Console.WriteLine("What is your name?");
string name = Console.ReadLine();

// Asks what course the student is on and saves it as a string
Console.WriteLine("What course are you on?");
string course = Console.ReadLine();

// Asks what page number and saves as a string, then converts it to an int
Console.WriteLine("What page number?");
string page = Console.ReadLine();
int pageAsInt = Convert.ToInt32(page);

// Asks if help is needed, saves response as a string, then coverts it to a bool
Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
string needHelp = Console.ReadLine();
bool needHelpBool = Convert.ToBoolean(needHelp);

// Asks if there were positive experiences the student would like to share, saves response as a string
Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
string posExp = Console.ReadLine();

// Asks about feedback, saves as a string
Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
string feedback = Console.ReadLine();

// Asks how many hours studied, saves as a string, coverts to an int
Console.WriteLine("How many hours did you study today?");
string hours = Console.ReadLine();
int hoursInt = Convert.ToInt32(hours);

// Thanks the student and provides an exit message
Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
