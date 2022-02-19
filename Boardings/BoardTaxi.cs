namespace Lab1.Boardings;

public class BoardTaxi : BoardAnyCar
{
    public BoardTaxi() : base(4)
    {
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