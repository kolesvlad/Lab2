namespace Lab2;

public class DiningCarriage : Carriage
{

    public int TableCount { get; set; }
    
    public DiningCarriage(int id, int type, int weight, int length, int tableCount) : base(id, type, weight, length)
    {
        TableCount = tableCount;
    }
}