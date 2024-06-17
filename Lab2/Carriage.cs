namespace Lab2;

public abstract class Carriage
{
    public int Id { get; set; }
    public string Type { get; set; }
    public double Weight { get; set; }
    public double Length { get; set; }

    public Carriage(int id, string type, double weight, double length)
    {
        Id = id;
        Type = type;
        Weight = weight;
        Length = length;
    }

    public abstract void SetNewId(int id);

    public abstract void ChangeConfiguration(string type, double weight, double length);
}