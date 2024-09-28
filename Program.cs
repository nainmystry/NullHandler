

VehicleFactory vehicleFactory = new VehicleFactory();

var vehicle = vehicleFactory.GetVehicle(VehicleType.Unknown);
//Since the unknown type is not handled, 
//instead of throwing error,
//we will give a default behavior

Console.WriteLine(vehicle.getSeatingCapacity().ToString());
vehicle.startEngine();