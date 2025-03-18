
namespace ConstructorChain
{
    public class Class1
    {
        // First constructor just takes number input and passes default name and multiplier
        public Class1(int number) : this("Guest User", number, 2) { }
        // Next two take either a name and number or a number and multiplier and pass defaults accordingly
        public Class1(string name, int number) : this(name, number, 2) { }
        public Class1(int number, int mult) : this("Guest User", number, mult) { }
        // Lastly we take all arguments, defualt or user input, and produce a result
        public Class1(string name, int number, int mult)
        {
            int result = number * mult;
            Console.WriteLine("Hello, {0}, here is your result: {1}", name, result);
        }
    }
}
