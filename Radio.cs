public interface IAudio
{
    void AdjustVolume(int value);
}

public class Radio : IAudio
{
    private int volume = 0;
}

void IAudio.AdjustVolume(int value)
{
    volume += value;
}

public int Volume
{
    get
    {
        return volume;
    }
    set
    {
        volume = value;
    }
}

private double station = 94.1;

public double Station
{
    get
    {
        return station;
    }
    set
    {
        station = value;
    }
}

public void Receive() {}

}

public enum RadioBand
{
    AM, FM
}

public class AMFMRadio : Radio
{
    private RadioBand band = RadioBand.AM;
    public RadioBand Band
    {
        get
        {
            return band;
        }
        set
        {
            band = value;
        }
    }
}

public class CommunicationRadio : Radio
{
    public void Transmit() {}
}

public class BoomBox
{
    private AMFMRadio radio;
    
    public AMFMRadio Radio
    {
        get
        {
            return radio;
        }
    }
    
    Boombox()
    {
        radio = new AMFMRadio();
    }
}
        