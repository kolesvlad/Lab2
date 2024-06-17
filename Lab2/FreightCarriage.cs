namespace Lab2;

public class FreightCarriage : Carriage
{

    public int PayloadWeight { get; set; }
    
    public FreightCarriage(int id, int type, int weight, int length, int payloadWeight) : base(id, type, weight, length)
    {
        PayloadWeight = payloadWeight;
    }
}