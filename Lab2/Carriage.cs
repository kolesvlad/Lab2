namespace Lab2;

public class Carriage
{
    public int Id { get; set; }
    public int Type { get; set; }
    public int Weight { get; set; }
    public int Length { get; set; }

    public Carriage(int id, int type, int weight, int length)
    {
        Id = id;
        Type = type;
        Weight = weight;
        Length = length;
    }
    
    
}