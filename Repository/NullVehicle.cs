public class NullVehicle : IVehicle
{
    public int getSeatingCapacity()
    {
        //default behavior
       return 0;
    }

    public void startEngine()
    {
        //default behavior
        Console.WriteLine("No Vehicle here.");
    }
}