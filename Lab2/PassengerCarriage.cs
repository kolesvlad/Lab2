namespace Lab2;

public class PassengerCarriage : Carriage
{
    public int SeatCount;
    
    public PassengerCarriage(int id, int type, int weight, int length, int seatCount) : base(id, type, weight, length)
    {
        SeatCount = seatCount;
    }
}