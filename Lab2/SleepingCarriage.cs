namespace Lab2;

public class SleepingCarriage : Carriage
{
    public int CompartmentsCount { get; set; }
    
    public SleepingCarriage(int id, string type, double weight, double length, int compartmentsCount) : base(id, type, weight, length)
    {
        CompartmentsCount = compartmentsCount;
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