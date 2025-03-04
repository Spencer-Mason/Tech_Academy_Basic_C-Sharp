namespace CallingMethods
{
    //Create class
    class MathsClass
    {
        // Method to add 5 to user's number, with 'userNum' as a parameter
        public static int Adding(int userNum)
        {
            int numberAdded = userNum + 5;
            return numberAdded;
        }
        // Method to multiply by two. Same parameter as adding method
        public static int Multiply(int userNum)
        {
            int numberMult = userNum * 2;
            return numberMult;
        }
        // Dividing method. In this example we see that you don't need to create a variable.
        // You can just return the math equation.
        public static int Divide(int userNum)
        {
            return userNum / 2;
        }
    }
}
