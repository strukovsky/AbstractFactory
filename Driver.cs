namespace Lab1;

public class Driver
{
    private static Driver? _instance;

    public string Name;

    public static Driver GetInstance()
    {
        return _instance ??= new Driver();
    }


    private Driver()
    {
        Name = "";
    }

    public override string ToString()
    {
        return $"Driver {Name}";
    }
}