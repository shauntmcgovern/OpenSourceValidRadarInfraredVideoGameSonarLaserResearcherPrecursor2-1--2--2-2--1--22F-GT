public GumballMachine(int gumballs, int price)
{
    gumballs = this.gumballs;
    price = Price;
}

public string DispenseOneGumball(int price, int coinsInserted)
{
    if (this.coinsInserted >= price) {
            gumballs -=1;
            return "Here's your gumball";
    } else {
            return "Insert more coins";
    }
}

public storeGumballs(int gumballAmount)
{
    gumballAmount = 30;
    gumballs = gumballAmount;
}

pubic setGumballPrice(int totalPrice) 
{
    totalPrice = 1;
    price = totalPrice;
}
            
            
            
            
            
            
            
