using System.Text;
using Lab1.Drivers;
using Lab1.Passengers;

namespace Lab1.Boardings;

public abstract class BoardAnyCar
{
    private Driver? _driver;
    private readonly List<Passenger> _passengers;
    private int _passengersLimit;

    public virtual void BoardPassenger(Passenger passenger)
    {
        if (_passengers.Count <= _passengersLimit)
        {
            _passengers.Add(passenger);
            _passengersLimit++;
        }
        else throw new CarIsFullException();
    }

    protected void BoardDriver(Driver driver) => _driver = driver;

    protected BoardAnyCar(int passengersLimit)
    {
        _passengersLimit = passengersLimit;
        _passengers = new List<Passenger>();
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        var driverString = _driver?.ToString() ?? "Driver is not specified";
        result.Append($"{driverString}. Passengers are:\n");
        foreach (var passenger in _passengers)
        {
            result.Append(passenger);
            result.Append('\n');
        }

        return result.ToString();
    }

    protected bool IsDriverInCab() => _driver != null;

    protected int GetCurrentPassengersCount() => _passengers.Count;
    public abstract void StartVoyage();
}