using Lab2;

class Program
{
    static void Main()
    {
        Carriage pCarriage1 = new PassengerCarriage(1, "passenger", 100.0, 100.0, 100, "first", 50);
        Carriage pCarriage2 = new PassengerCarriage(2, "passenger", 100.0, 100.0, 120, "second", 60);
        Carriage pCarriage3 = new PassengerCarriage(3, "passenger", 100.0, 100.0, 80, "second", 40);
        
        Carriage fCarriage1 = new FreightCarriage(4, "freight", 200.0, 100.0, 1000, "sand", true);
        Carriage fCarriage2 = new FreightCarriage(5, "freight", 200.0, 100.0, 1200, "rocks", false);
        Carriage fCarriage3 = new FreightCarriage(6, "freight", 200.0, 100.0, 800, "wood", false);
        
        Carriage dCarriage1 = new DiningCarriage(7, "dining", 100.0, 100.0, 10, true);
        (dCarriage1 as DiningCarriage)?.SetWindowCount(30);
        (dCarriage1 as DiningCarriage)?.SetStuffNumber(5);
        (dCarriage1 as DiningCarriage)?.SetAvailableDishCount(10);
        (dCarriage1 as DiningCarriage)?.SetAvailableDishTypes([Dish.Vegetables, Dish.Meat]);
        (dCarriage1 as DiningCarriage)?.SetAllLampsCount(75);
        Carriage dCarriage2 = new DiningCarriage(8, "dining", 100.0, 100.0, 15, false);
        Carriage dCarriage3 = new DiningCarriage(9, "dining", 100.0, 100.0, 5, false);
        
        Carriage sCarriage1 = new SleepingCarriage(10, "sleeping", 80.0, 120.0, 100, true);
        Carriage sCarriage2 = new SleepingCarriage(11, "sleeping", 80.0, 120.0, 90, false);
        Carriage sCarriage3 = new SleepingCarriage(12, "sleeping", 80.0, 120.0, 110, false);
        
        Train train = new Train(new Lab2.LinkedList<Carriage>(), "Intercity", "55");
        
        train.AddCarriage(pCarriage1);
        train.AddCarriage(pCarriage2);
        train.AddCarriage(dCarriage1);
        train.AddCarriage(sCarriage1, 1);
        train.AddCarriage(sCarriage2);
        train.AddCarriage(sCarriage3);
        train.RemoveCarriage(train.Carriages.ConvertToList().Count - 1);
        train.AddCarriage(dCarriage2, train.Carriages.ConvertToList().Count - 1);
        train.RemoveCarriage(dCarriage2);
        
        train.DisplayTrainCarriagesInfo();
        
        train.FindCarriageByType("passenger");
        train.FindCarriageByWeight(50.0);
        train.FindCarriageByLength(50.0);

        train.CalculateTrainWeight();

        train.FilterCarriagesByMaxLoadCapacity(900);
        train.FilterCarriagesBySeatCount(90);
        
        train.GetAllPassengerCount();

        train.GetMaxLoadCapacityCarriage();

        train.CalculateEachCarriageTypeUnits();

        train.TrainContainsExplosives();
    }
}