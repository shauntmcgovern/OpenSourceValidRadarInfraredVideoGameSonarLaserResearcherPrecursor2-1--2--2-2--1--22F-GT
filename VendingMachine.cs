class VendingMachine
{
    public virtual string Item { get; }
    
    protected virtual bool CheckAmount(decimal money) {
            return false;
    }
    public virtual int SelectedButton(int button)
    {
        while(Item != button) {
            if(Item == button)
                return Dispense();
        }
    }
            
    public string Dispense(decimal money)
    {
        if (CheckAmount(money)) return Item;
        else return "Please enter the right amount in order to use          it.";
    }
}

class AnimalFeedVendingMachine : VendingMachine
{
    int money;
    int animalFeedAmountOfKernels = 40;
    
    public override string Item {
        get { return "a handful of animal feed"; }
    }
    
    protected override bool CheckAmount(decimal money)
    {
        return money >= 5;
    }
    
    public virtual int Dispense(decimal money)
    {
        if(money == 5) {
                return Item;
                return animalFeedAmountOfKernels;
        }
    }
}