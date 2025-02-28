bool end = false;

while(!end)
{
    Console.WriteLine("Guess a number from 1 to 50:");
    int guess = Convert.ToInt32(Console.ReadLine());
    bool correct = guess == 42;
    do
    {
        switch (guess)
        {
            case 42:
                Console.WriteLine("That's right! GG.");
                correct = true;
                break;
            default:
                Console.WriteLine("You guessed " + guess + ". Sorry, that's wrong. Try again.");
                guess = Convert.ToInt32(Console.ReadLine());
                break;
        }
    }
    while (!correct);
    end = true;
}