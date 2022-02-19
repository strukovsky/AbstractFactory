using Lab1.Boardings;
using Lab1.Drivers;

namespace Lab1.Example;

public class TaxiVoyage
{
    public static void Perform()
    {
        var driver = TaxiDriver.GetInstance();
        driver.Name = "Nikolay";

        var first = new Passenger("Dmitry");
        var second = new Passenger("Yaroslav");

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