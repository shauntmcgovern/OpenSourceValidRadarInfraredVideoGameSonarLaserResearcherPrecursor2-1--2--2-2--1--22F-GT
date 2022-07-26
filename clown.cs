//To be honest all programming languages are the same, they just are written differently. Still have the same framework && architecture.
class clown {
    public string name;
    public int height;
    public string occupation;
    
    public void stateYourBusiness() {
        Console.WriteLine("My name is " + name + "and I am " + height + " inches tall " + " and I am a " + occupation);
    }
}

static void Main(string[] args) {
    clown oneClown = new clown();
    oneClown.name = "Boffo";
    oneClown.height = 14;
    oneClown.occupation = "Plumber";
    oneClown.stateYourBusiness(); 
    
    clown anotherClown = new clown();
    anotherClown.name = "Biff";
    anotherClown.height = 16;
    anotherClown.occupation = "Fighter";
    anotherClown.stateYourBusiness();
    
    clown clown3 = new clown();
    clown3.name = anotherClown.Name;
    clown3.height = oneClown.Height - 3;
    clown3.occupation = "Plumber's Assistant";
    clown3.stateYourBusiness();
    
    anotherClown.height *= 2;
    anotherClown.stateYourBusiness();
    
    clown lastClown = new clown();
    lastClown.name = "Doink";
    lastClown.height = 21;
    lastClown.occupation = "Wrestler";
    lastClown.stateYourBusiness();
	
    clown nextToLastClown = new clown();
    nextToLastClown.name = "Pointo Been";
    nextToLastClown.height = 33;
    nextToLastClown.occupation = "Paul Bunyon w/ Axe Statue, Organizer && Cleaner";
    nextToLastClown.stateYourBusiness();
}
