namespace Gems_Lab3;

public class Vehicle
{
    protected string Colour;
    protected string BodyType;
    protected virtual int LicensePlateNumber { get; set; }
    protected bool HasPassenger;
    protected virtual int Speed { get; set; }

    public Vehicle()
    {
        Colour = "";
        BodyType = "";
        LicensePlateNumber = 0;
        HasPassenger = false;
        Speed = 0;
    }
    
    public Vehicle(string colour, string type, int number, bool hasPass, int speed)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Некорректный номер!");

        Colour = colour;
        BodyType = type;
        LicensePlateNumber = number;
        HasPassenger = hasPass;
        Speed = speed;
    }

    public virtual int GetSpeed() => Speed;
    public virtual int GetLicensePlateNumber() => LicensePlateNumber;
    
}