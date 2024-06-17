namespace Lab2;

public class Train
{
    public LinkedList<Carriage> Carriages;
    public string Name;
    public string RouteNumber;

    public Train(LinkedList<Carriage> carriages, string name, string routeNumber)
    {
        Carriages = carriages;
        Name = name;
        RouteNumber = routeNumber;
    }

    public void AddCarriage(Carriage carriage)
    {
        Carriages.Add(carriage);
    }
    
    public void AddCarriage(Carriage carriage, int position)
    {
        Carriages.AddAt(carriage, position);
    }
    
    public void RemoveCarriage(Carriage carriage)
    {
        Carriages.Remove(carriage);
    }
    
    public void RemoveCarriage(Carriage carriage, int position)
    {
        Carriages.RemoveAt(carriage, position);
    }

    public List<Carriage> FindCarriageByType(string type)
    {
        List<Carriage> result = new List<Carriage>();
        
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (carriage.Type.Equals(type))
            {
                result.Add(carriage);
            }
        }

        return result;
    }
    
    public List<Carriage> FindCarriageByWeight(double weight)
    {
        List<Carriage> result = new List<Carriage>();
        
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (Math.Abs(carriage.Weight - weight) < 0.001)
            {
                result.Add(carriage);
            }
        }

        return result;
    }
    
    public List<Carriage> FindCarriageByLength(double length)
    {
        List<Carriage> result = new List<Carriage>();
        
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (Math.Abs(carriage.Length - length) < 0.001)
            {
                result.Add(carriage);
            }
        }

        return result;
    }

    public double CalculateTrainWeight()
    {
        return Carriages.ConvertToList().Sum(carriage => carriage.Weight);
    }

    public void DisplayCarriageInfo(Carriage carriage)
    {
        Console.WriteLine($"{nameof(Carriage.Id)}: {carriage.Id}," +
                          $" {nameof(Carriage.Type)}: {carriage.Type}, " +
                          $"{nameof(Carriage.Weight)}: {carriage.Weight}, " +
                          $"{nameof(Carriage.Length)}: {carriage.Length}");
    }

    public void DisplayTrainCarriagesInfo()
    {
        foreach (var carriage in Carriages.ConvertToList())
        {
            DisplayCarriageInfo(carriage);
        }
    }
}