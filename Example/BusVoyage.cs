using Lab1.Boardings;
using Lab1.Drivers;
using Lab1.Passengers;

namespace Lab1.Example;

public class BusVoyage
{
    public static void Perform()
    {
        var driver = new BusDriver("Petya", 10001);
        var first = new PersonPassenger("Dima");
        var second = new CargoPassenger(10,10,10);

        var boarding = new BoardBus();
        boarding.BoardBusDriver(driver);
        try
        {
            boarding.BoardPassenger(first);
            boarding.BoardPassenger(second);
            boarding.StartVoyage();
        }
        catch (NoDriverInCarException)
        {
            Console.WriteLine("Cannot start a voyage due to lack of driver");
        }
        catch (CarIsFullException)
        {
            Console.WriteLine("Error occured while adding new passenger: car is already full");
        }
    }
}