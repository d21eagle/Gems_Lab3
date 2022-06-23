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

    public virtual int GetSpeed() => Speed;
    public virtual int GetLicensePlateNumber() => LicensePlateNumber;
}