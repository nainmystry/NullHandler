public class Truck : IVehicle
{
    public int getSeatingCapacity()
    {
        return 16;
    }

    public void startEngine()
    {
       Console.WriteLine("Engine Start.");
    }
}