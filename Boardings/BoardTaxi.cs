using Lab1.Drivers;
using Lab1.Passengers;

namespace Lab1.Boardings;

public class BoardTaxi : BoardAnyCar
{
    public BoardTaxi() : base(4)
    {
    }
    
    
    public override void BoardPassenger(Passenger passenger)
    {
        base.BoardPassenger(passenger);
        Console.WriteLine($"Taxi: boarded {passenger}");
    }

    public void BoardTaxiDriver(TaxiDriver driver)
    {
        BoardDriver(driver);
        Console.WriteLine($"Taxi: boarded driver {driver}");
    }

    public override string ToString() => $"Taxi: {base.ToString()}";
    public override void StartVoyage()
    {
        if (IsDriverInCab())
        {
            Console.WriteLine("Boarded successfully a taxi");
            Console.WriteLine($"Boarding:\n{ToString()}");
        }
        else
        {
            throw new NoDriverInCarException();
        }
    }
}