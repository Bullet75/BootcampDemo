
//SRP EXAMPLE

public class DisneyWorld
{
    public void DoOpenHours()
    {
        //Open the gate functinality
    }

    public void VehicleType(Train train)
    {
        //Check if garage is opened
        //finish the vehicle service
    }

    public void DoCloseHours()
    {
        //Close the gate functinality
    }
}

// APPLYING SRP

public class DisneyWorld
{
    IDisneyStuff _disneyStuff;

    public DisneyWorld(IDisneyStuff disneyStuff)
    {
        this._disneyStuff = disneyStuff;
    }
    public void OpenForAll()
    {
        _disneyStuff.OpenHour();
    }
    public void ForAll()
    {
        //Check and finish when is open
    }
    public void CloseHours()
    {
        _disneyStuff.CloseHour();
    }
}
public class DisneyStuff : IDisneyStuff
{
    public void OpenHour()
    {
        //Open Disney World
    }

    public void CloseHour()
    {
        //Close Disney World
    }
}

public interface IDisneyStuff
{
    void OpenHour();
    void CloseHour();
}
