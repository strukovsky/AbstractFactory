namespace Lab1.Drivers;

public class BusDriver : Driver
{
    public int Id;

    public BusDriver(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public override string ToString() => $"Bus driver {Name} with identifier {Id}";
}