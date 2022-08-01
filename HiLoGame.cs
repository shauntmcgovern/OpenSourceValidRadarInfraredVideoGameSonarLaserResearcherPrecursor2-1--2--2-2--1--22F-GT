class Guy
{
    public string Name;
    public int Cash;
    
    public void WriteMyInfo()
    {
        Console.WriteLine(Name + " has " + Cash + " bucks.");
    }
    
    public int GiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't a valid amount");
            return 0;
        }
        if (amount > Cash)
        {
            Console.WriteLine(Name + " says: " +
                                "I don't have enough cash to give you " + amount);
            return 0;
        }
        Cash -= amount;
        return amount;
    }
    
    public void ReceiveCash(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine(Name + " says: " + amount + " isn't an amount I'll take");
        }
        else
        {
            Cash += amount;
        }
    }
}

static void Main(String[] args)
{
    Guy shaun = new Guy() { Cash = 100, Name = "Shaun" };
    Guy terence = new Guy() { Cash = 200, Name = "Terence" };
    
    while (true)
    {
        shaun.WriteMyInfo();
        terence.WriteMyInfo();
        Console.Write("Enter an amount: ");
        string howMuch = Console.ReadLine();
        if (howMuch == "") return;
        if (int.TryParse(howMuch, out int amount))
        {
            Console.Write("Who should give the cash: ");
            string whichGuy = Console.ReadLine();
            if (whichGuy == "Shaun")
            {
                int cashGiven = shaun.GiveCash(amount);
                terence.ReceiveCash(cashGiven);
            }
            else if (whichGuy == "Terence")
            {
                int cashGiven = bod.GiveCash(amount);
                shaun.ReceiveCash(cashGiven);
            }
            else
            {
                Console.WriteLine("Please enter 'Shaun' or 'Terrence'");
            }
        }
        else
        {
            Console.WriteLine("Please enter an amount (or a blank line to exit).");
        }
    }
}
    
            
            
            
            
            
            
            
