public class VehicleFactory
{
    public IVehicle GetVehicle(VehicleType vehicle)
    {
        switch (vehicle)
        {
            case VehicleType.Car:
            return new Car();
            case VehicleType.Truck:
            return new Truck();
            default:
            return new NullVehicle();
        }
    }
}