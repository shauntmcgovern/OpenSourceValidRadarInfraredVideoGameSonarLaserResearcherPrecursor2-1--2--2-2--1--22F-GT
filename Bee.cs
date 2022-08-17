class Bee
{
    public virtual float CostPerShift { get; }
    
    public string Job { get; private set; }
    
    public Bee(string job)
    {
        Job = job;
    }
    
    public void WorkTheNextShift()
    {
        if (HoneyVault.ConsumeHoney(CostPerShift))
        {
            DoJob();
        }
    }
    
    protected virtual void DoJob()
}

class NectorCollector : Bee
{
    public const float NECTAR_COLLECTED_PER_SHIFT = 33.25f;
    public override float CostPerShift { get { return 1.95f; } }
    public NectarCollector() : base("Nectar Collectoer") { }
    
    protected overrride void DoJob()
    {
        HoneyVault.CollectNectar(NECTAR_COLLECTED_PER_SHIFT);
    }
}

class HoneyManufacturer : Bee
{
    public const float NECTAR_PROCESSED_PER_SHIFT = 33.15f;
    public override float CostPerShift { get { return 1.7f; } }
    public HoneyManufacturer() : base("Honey Manufacturer") { }
    
    protected override void DoJob()
    {
        HoneyVault.ConvertNectarToHoney(NECTAR_PROCESSED_PER_SHIFT);
    }
}