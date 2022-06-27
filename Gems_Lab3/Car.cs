namespace Gems_Lab3;

public class Car : Vehicle
{
    protected override int Speed { get; set; }
    protected override int LicensePlateNumber { get; set; }
    
    public Car(string colour, string type, int number, bool hasPass, int speed)
        : base(colour, type, number, hasPass, speed) { }
    
    public override int GetSpeed() => Speed;
    public override int GetLicensePlateNumber() => LicensePlateNumber;
    
    public override string ToString()
    {
        return "Car {" + Colour + ", " + BodyType + ", "
            + LicensePlateNumber + ", " + HasPassenger + ", "
            + Speed + "km/h" + "}";
    }
}