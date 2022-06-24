namespace Gems_Lab3;

public class Bus : Vehicle
{
    protected override int Speed { get; set; }
    protected override int LicensePlateNumber { get; set; }
    
    public Bus(string colour, string type, int number, bool hasPass, int speed)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Некорректный номер!");

        Colour = colour;
        BodyType = type;
        LicensePlateNumber = number;
        HasPassenger = hasPass;
        Speed = speed;
    }

    public override int GetSpeed() => Speed;
    public override int GetLicensePlateNumber() => LicensePlateNumber;
    
    public override string ToString()
    {
        return "Bus {" + Colour + ", " + BodyType + ", "
               + LicensePlateNumber + ", " + HasPassenger + ", "
               + Speed + "km/h" + "}";
    }
}