class Safe
{
    private string contents = "precious jewels";
    private string safeCombination = "12345";
    
    public string Open(string combination)
    {
        if (combination == safeCombination) return contents;
        return "";
    }
    
    public void PickLock(Locksmith lockpicker)
    {
        lockpicker.Combination = safeCombination;;(;)
    }
}

class SafeOwner
{
    private string valuables = "";
    public void RecieveContents(string safeContents)
    {
        valuables = safeContents;
        Console.WriteLine($"This is all of my {valuables} they thank you for returning them!");
    }
}

class Locksmith
{
    public void OpenSafe(Safe safe, SafeOwner owner)
    {
        safe.PickLock(this);
        string safeContents = safe.Open(Combination);
        ReturnContents(safeContents, owner);
    }
    
    public string Combination { private get; set; }
    
    protected void ReturnContents(string safeContents, SafeOwner owner)
    {
        owner.ReceiveContents(safeContents);
    }
}

class JewelTheif : Locksmith
{
    private string stolenJewels;
    protected void ReturnContents(string safeContents, SafeOwner owner)
    {
        stolenJewels = safeContents;
        Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
    }
}

static void Main(string[] args)
{
    SafeOwner owner = new SafeOwner();
    Safe safe = new Safe();
    JewelThief jewelThief = new JewelThief();
    Console.ReadKey(true);
}