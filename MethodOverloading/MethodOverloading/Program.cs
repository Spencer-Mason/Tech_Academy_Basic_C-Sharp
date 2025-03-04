using MethodOverloading;

class Program
{
    static void Main()
    {
        // Changing which method is being used by
        // passing in different data types
        Console.WriteLine(MathsClass.Math(20)); // int
        Console.WriteLine(MathsClass.Math(50.54)); // double
        Console.WriteLine(MathsClass.Math("10")); // string
    }
}