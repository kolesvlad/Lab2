namespace Lab2;

public class DiningCarriage : Carriage
{
    public int TablesCount { get; set; }
    public bool HasKitchen { get; set; }
    
    public DiningCarriage(int id, string type, double weight, double length, int tablesCount, bool hasKitchen) : base(id, type, weight, length)
    {
        TablesCount = tablesCount;
        HasKitchen = hasKitchen;
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