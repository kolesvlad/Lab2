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
        if (!IsNewCarriageAccepted(carriage)) return;
        
        Carriages.Add(carriage);
    }
    
    public void AddCarriage(Carriage carriage, int position)
    {
        if (!IsNewCarriageAccepted(carriage)) return;

        Carriages.AddAt(carriage, position);
    }
    
    public void RemoveCarriage(Carriage carriage)
    { 
        Carriages.Remove(carriage);
    }
    
    public void RemoveCarriage(int position)
    {
        Carriages.RemoveAt(position);
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
        Console.WriteLine($"{nameof(Carriage.Id)}: {carriage.Id}, " +
                          $"{nameof(Carriage.Type)}: {carriage.Type}, " +
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

    public bool IsNewCarriageAccepted(Carriage carriage)
    {
        if (!IsCarriageUnique(carriage))
        {
            return false;
        }
        return carriage.GetType() == typeof(FreightCarriage) ? IsAllCarriagesFreight() : IsAllCarriagesPassenger();
    }

    private bool IsCarriageUnique(Carriage newCarriage)
    {
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (carriage.Id == newCarriage.Id)
            {
                return false;
            }
        }

        return true;
    }
    
    private bool IsAllCarriagesFreight()
    {
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (carriage.GetType() == typeof(PassengerCarriage))
            {
                return false;
            }
        }

        return true;
    }

    private bool IsAllCarriagesPassenger()
    {
        foreach (var carriage in Carriages.ConvertToList())
        {
            if (carriage.GetType() == typeof(FreightCarriage))
            {
                return false;
            }
        }

        return true;
    }

    public List<Carriage> FilterCarriagesByType(string type)
    {
        return Carriages.ConvertToList().FindAll(carriage => carriage.Type.Equals(type));
    }

    public List<Carriage> FilterCarriagesByMaxLoadCapacity(double maxLoadCapacity)
    {
        return FilterCarriagesByType("freight")
            .FindAll(carriage => (carriage as FreightCarriage)!.MaxLoadCapacity >= maxLoadCapacity)
            .ToList();
    }
    
    public List<Carriage> FilterCarriagesBySeatCount(int seatCount)
    {
        return FilterCarriagesByType("passenger")
            .FindAll(carriage => (carriage as PassengerCarriage)!.SeatsCount >= seatCount)
            .ToList();
    }

    public int GetAllPassengerCount()
    {
        return FilterCarriagesByType("passenger")
            .Select(carriage => (carriage as PassengerCarriage)!.PassengerCount)
            .Sum();
    }

    public Carriage? GetMaxLoadCapacityCarriage()
    {
        List<Carriage> freightCarriages = FilterCarriagesByType("freight");
        return freightCarriages.Count == 0 ? null : freightCarriages
            .OrderByDescending(carriage => (carriage as FreightCarriage)!.MaxLoadCapacity)
            .First();
    }

    public Dictionary<Type, int> CalculateEachCarriageTypeUnits()
    {
        Dictionary<Type, int> result = new Dictionary<Type, int>();
        result.Add(typeof(PassengerCarriage), 0);
        result.Add(typeof(FreightCarriage), 0);
        result.Add(typeof(DiningCarriage), 0);
        result.Add(typeof(SleepingCarriage), 0);

        foreach (var carriage in Carriages.ConvertToList())
        {
            if (carriage.GetType() == typeof(PassengerCarriage))
            {
                result[typeof(PassengerCarriage)] += 1;
            }
            else if (carriage.GetType() == typeof(FreightCarriage))
            {
                result[typeof(FreightCarriage)] += 1;
            }
            else if (carriage.GetType() == typeof(DiningCarriage))
            {
                result[typeof(DiningCarriage)] += 1;
            }
            else if (carriage.GetType() == typeof(SleepingCarriage))
            {
                result[typeof(SleepingCarriage)] += 1;
            }
        }

        return result;
    }

    public bool TrainContainsExplosives()
    {
        List<Carriage> carriagesWithExplosives = FilterCarriagesByType("freight")
            .FindAll(carriage => (carriage as FreightCarriage)!.ContainsExplosives)
            .ToList();
        return carriagesWithExplosives.Count > 0;
    }
    
}