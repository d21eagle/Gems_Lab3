namespace Gems_Lab3.Model;

public class Truck : Vehicle
{
    public Truck(Colour vehicleColour, int licensePlateNumber, bool hasPassenger)
        : base(vehicleColour, licensePlateNumber, hasPassenger) { }
    
    public override int GetSpeed() => Random.Next(70, 101);
}