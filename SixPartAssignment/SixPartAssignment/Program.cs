// Assignment Part One

// Create array of strings
using System.Drawing;

string[] words = { "some", "words", "to", "append", "user", "text"};

// Ask for user input
Console.WriteLine("Please enter some text to append:");
string userText = Console.ReadLine();

// Loop through array and append user's entered text
for (int i = 0; i < words.Length; i++)
{
    words[i] += userText;
}

// Loop through modified words and print them
Console.WriteLine("\nHere's the results:");
foreach (string word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("\n\n");
// ====================================================
// Assigment Part Two
// Create and fix infinite loop

bool loop = true;
Console.WriteLine("Press enter for infinite power:");
Console.ReadLine();

// This will produce an infinite loop
//while (loop)
//{
//    Console.WriteLine("INFINITE POWER!!!");
//}

while (loop)
{
    Console.WriteLine("INFINITE POWER!!!");
    loop = false; // Adding this line breaks the loop
}

Console.WriteLine("\n\n");
// ====================================================
// Assignment Part Three

// Loop using less than operator
// Counts from 0 to 4

int count1 = 0;
while (count1 < 5)
{
    Console.WriteLine(count1);
    count1++;
}

Console.WriteLine("\n");
// Loop using less than OR equal to operator
// Counts from 0 to 5

int count2 = 0;
while (count2 <= 5)
{
    Console.WriteLine(count2);
    count2++;
}

Console.WriteLine("\n\n");
// ====================================================
// Assignment Part Four

// List of colors
List<string> primaryColors = [ "blue", "red", "yellow" ];

// Ask user for input
Console.WriteLine("Enter a primary color to see it's index:");
string userColor = Console.ReadLine();

// Check if input is not on the list
while (!primaryColors.Contains(userColor))
{
    Console.WriteLine("Sorry, " + userColor + " is not a primary color, or you spelled it wrong. Please try again.");
    userColor = Console.ReadLine();
}

// Loop through list to find entered color and display it's index
foreach (string color in primaryColors)
{
    if (color == userColor)
    {
        Console.WriteLine("The color " + userColor + " has an index of: " + primaryColors.IndexOf(color));
        break;
    }
}

Console.WriteLine("\n\n");
// ====================================================
// Assignment Part Five

// Create list of test scores
List<int> testScores = [85, 98, 72, 68, 55, 32, 98, 100, 85];

// Ask user for input
Console.WriteLine("Enter a test score (out of 100) to see the indicies:");
int userScore = Convert.ToInt32(Console.ReadLine());

// If the score is on the list, print the indicies using a loop
if (testScores.Contains(userScore))
{
    Console.WriteLine("Score " + userScore + " is at the following indicies:");
    for (int i = 0; i < testScores.Count; i++)
    {
        if (testScores[i] == userScore)
        {
            Console.WriteLine(i);
        }
    }
}
// If score is not present, notify user
else
{
    Console.WriteLine("There is no score of " + userScore + " on the list.");
}

Console.WriteLine("\n\n");
// ====================================================
// Assignment Part Six

// Create a list of letters
List<string> letters = ["A", "B", "C", "B", "D", "E", "C"];

// Index varriable to keep track of current loop iteration
int letterIndex = 0;

// Loop through list
foreach (string letter in letters)
{
    // If the list up to (but not including) current index includes current letter, it is a duplicate
    if (letters[..letterIndex].Contains(letter))
    {
        Console.WriteLine(letter + " is a duplicate.");
    }
    else
    {
        Console.WriteLine(letter + " is unique.");
    }
    // Increment index tracker
    letterIndex++;
}