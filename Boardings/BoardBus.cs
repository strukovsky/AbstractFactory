using Lab1.Drivers;
using Lab1.Passengers;

namespace Lab1.Boardings;

public class BoardBus : BoardAnyCar
{
    public BoardBus() : base(30)
    {
    }


    public override string ToString() => $"Bus: {base.ToString()}";

    public override void BoardPassenger(Passenger passenger)
    {
        base.BoardPassenger(passenger);
        Console.WriteLine($"Bus: boarded {passenger}");
    }

    public void BoardBusDriver(BusDriver driver)
    {
        base.BoardDriver(driver);
        Console.WriteLine($"Bus: boarded driver {driver}");
    }

    public override void StartVoyage()
    {
        if (IsDriverInCab())
        {
            Console.WriteLine($"Boarded successfully a bus with {GetCurrentPassengersCount()} passengers");
            Console.WriteLine($"Boarding:\n{ToString()}");
        }
        else
        {
            throw new NoDriverInCarException();
        }
    }
}