namespace Gems_Lab3.Model;

public class Vehicle
{
    protected readonly Random Random = new Random();
    private Colour VehicleColour { get; }
    public int LicensePlateNumber { get; }
    private bool HasPassenger { get; }

    public Vehicle(Colour vehicleColour, int licensePlateNumber, bool hasPassenger)
    {
        VehicleColour = vehicleColour;
        LicensePlateNumber = licensePlateNumber;
        HasPassenger = hasPassenger;
    }

    public virtual int GetSpeed() => 0;
}