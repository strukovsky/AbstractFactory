namespace Lab1.Passengers;

public class CargoPassenger : Passenger
{
    public int Width;
    public int Height;
    public int Depth;

    public CargoPassenger(int width, int height, int depth)
    {
        Width = width;
        Height = height;
        Depth = depth;
    }

    public override string ToString()
    {
        return $"Cargo: {Width}x{Height}x{Depth}";
    }
}