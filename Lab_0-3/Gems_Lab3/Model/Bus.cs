namespace Gems_Lab3.Model;

public class Bus : Vehicle
{
    public Bus(Colour vehicleColour, int licensePlateNumber, bool hasPassenger)
        : base(vehicleColour, licensePlateNumber, hasPassenger) { }
    
    public override int GetSpeed() => Random.Next(80, 111);
}