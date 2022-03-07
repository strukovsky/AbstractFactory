using Lab1.Boardings;
using Lab1.Drivers;
using Lab1.Passengers;

namespace Lab1.Example;

public class TaxiVoyage
{
    public static void Perform()
    {
        var driver = new TaxiDriver("Nikolay");
        var first = new PersonPassenger("Vova");
        var second = new CargoPassenger(100,10,10);

        var boarding = new BoardTaxi();
        boarding.BoardTaxiDriver(driver);
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