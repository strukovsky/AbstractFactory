namespace Lab1.Drivers;

public abstract class Driver
{
    protected static Driver? Instance;

    public string Name;


    protected Driver()
    {
        Name = "";
    }

    public abstract override string ToString();
}