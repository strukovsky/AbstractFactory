namespace Lab1.Drivers;

public class TaxiDriver : Driver
{
    public TaxiDriver(string name)
    {
        Name = name;
    }

    public override string ToString() => $"Taxi driver {Name}";
}