namespace Lab1.Passengers;

public class PersonPassenger : Passenger
{
     public readonly string Name;

     public PersonPassenger(string name)
     {
          Name = name;
     }

     public override string ToString()
     {
          return $"Person {Name}";
     }
}