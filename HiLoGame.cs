static class HiLoGame
{
    public const int MAXIMUM = 10;
    private static Random random = new Random();
    private static int currentNumber = random.Next(1, MAXIMUM + 1);
    private static int jackpot = 10;
    
    public static int GetPot() {return pot;}
    
    public static void Guess(bool higher)
    {
        int givenNumber = random.Next(1, MAXIMUM + 1);
        if ((higher && givenNumber >= currentNumber) || (!higher && givenNumber <= currentNumber))
        {
            Console.WriteLine("You guessed right!");
            jackpot++;
        }
        else
        {
            Console.WriteLine("Bad luck, you guessed wrong.");
            jackpot--;
        }
        currentNumber = givenNumber;
        Console.WriteLine($"The current number is {currentNumber}");
    }
    
    public static void Hint()
    {
        int half = MAXIMUM / 2;
        if (currentNumber >= half)
            Console.WriteLine($"The number is at least {half}");
        else     
            Console.WriteLine($"The number is at most {half}");
        jackpot--;
    }
}

HiLoGame.random = new Random(1);
Random listOfNumbers = new Random(1);
Console.Write("The first 20 numbers will be: ");
for (int i = 0; i < 10; i++)
    Console.Write($"{listOfNumbers.Next(1, HiLoGame.MAXIMUM + 1)}, ");
    
        
        





























            
            
