namespace Lab2;

public class DiningCarriage : Carriage
{
    public int TablesCount { get; set; }
    public bool HasKitchen { get; set; }
    private int WindowCount { get; set; }
    private int StuffNumber { get; set; }
    private int AvailableDishCount { get; set; }
    private List<Dish> AvailableDishTypes { get; set; }
    private int AllLampsCount { get; set; }
    private int WorkingLampsCount { get; set; }
    private string WifiName { get; set; }
    private string WifiPassword { get; set; }
    private bool HasSoftSeats { get; set; }
    private bool HasCarpet { get; set; }
    
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

    public void SetWindowCount(int windowCount)
    {
        WindowCount = windowCount;
    }
    
    public void SetStuffNumber(int stuffNumber)
    {
        StuffNumber = stuffNumber;
    }
    
    public void SetAvailableDishCount(int availableDishCount)
    {
        AvailableDishCount = availableDishCount;
    }

    public void SetAvailableDishTypes(List<Dish> availableDishTypes)
    {
        AvailableDishTypes = availableDishTypes;
    }

    public void SetAllLampsCount(int allLampsCount)
    {
        AllLampsCount = allLampsCount;
    }
}

public enum Dish
{
    Meat, Fish, Vegetables
}