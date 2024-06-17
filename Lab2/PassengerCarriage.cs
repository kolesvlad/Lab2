namespace Lab2;

public class PassengerCarriage : Carriage
{
    public int SeatsCount { get; set; }
    public string ComfortLevel { get; set; }
    public int PassengerCount { get; set; }
    
    public PassengerCarriage(int id, string type, double weight, double length, int seatsCount, string comfortLevel, int passengerCount) : base(id, type, weight, length)
    {
        SeatsCount = seatsCount;
        ComfortLevel = comfortLevel;
        PassengerCount = passengerCount;
    }

    public override void SetNewId(int id)
    {
        throw new NotImplementedException();
    }

    public override void ChangeConfiguration(string type, double weight, double length)
    {
        throw new NotImplementedException();
    }
}