// This program determines if a person is qualified for car insurance based on their age and driving record.
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Have you ever had a DUI? Please answer 'true' or 'false'.");
bool dui = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("How many speeding tickets do you have?");
int tickets = Convert.ToInt32(Console.ReadLine());
bool qualified = age > 15 && !dui && tickets <= 3;
Console.WriteLine("Qualified?");
Console.WriteLine(qualified);