public class Car : IVehicle
{
    public int getSeatingCapacity()
    {
        return 5;
    }

    public void startEngine()
    {
        Console.WriteLine("Engine Start.");
    }
}