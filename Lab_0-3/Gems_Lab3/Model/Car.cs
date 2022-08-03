namespace Gems_Lab3.Model;

public class Car : Vehicle
{
    public Car(Colour vehicleColour, int licensePlateNumber, bool hasPassenger)
        : base(vehicleColour, licensePlateNumber, hasPassenger) { }
    
    public override int GetSpeed() => Random.Next(90, 151);
}