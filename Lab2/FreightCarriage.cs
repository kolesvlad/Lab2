namespace Lab2;

public class FreightCarriage : Carriage
{
    public double MaxLoadCapacity { get; set; }
    public string CargoType { get; set; }
    public bool ContainsExplosives { get; set; }
    
    public FreightCarriage(int id, string type, double weight, double length, double maxLoadCapacity, string cargoType, bool containsExplosives) : base(id, type, weight, length)
    {
        MaxLoadCapacity = maxLoadCapacity;
        CargoType = cargoType;
        ContainsExplosives = containsExplosives;
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