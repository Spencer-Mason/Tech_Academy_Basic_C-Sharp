using MethodOverloading;

class Program
{
    static void Main()
    {

        MathsClass math = new MathsClass();

        //Changing which method is being used by
        //passing in different data types
        Console.WriteLine(math.Math(20)); // int
        Console.WriteLine(math.Math(50.54)); // double
        Console.WriteLine(math.Math("10")); // string
    }
}