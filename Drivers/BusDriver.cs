namespace Lab1.Drivers;

public class BusDriver : Driver
{
    public int Id;
    
    public static BusDriver GetInstance()
    {
        return (BusDriver) (Instance ??= new BusDriver());
    }

    public override string ToString() => $"Bus driver {Name} with identifier {Id}";
    
}