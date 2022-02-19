namespace Lab1.Drivers;

public class TaxiDriver : Driver
{
    private TaxiDriver()
    {
        
    }
    
    public static TaxiDriver GetInstance()
    {
        return (TaxiDriver) (Instance ??= new TaxiDriver());
    }

    public override string ToString() => $"Taxi driver {Name}";
}