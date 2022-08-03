using Gems_Lab3.Model;

namespace Gems_Lab3;

static class Program
{
    private static Vehicle Generate()
    {
        Random random = new Random();
        
        var vehicleColour = (Colour) random.Next(Enum.GetNames<Colour>().Length);
        var licensePlateNumber = random.Next(100, 1000);
        var hasPassenger = random.Next(2) == 1;

        switch (random.Next(3))
        {
            case 0:
                return new Car(vehicleColour, licensePlateNumber, hasPassenger);
            case 1:
                return new Truck(vehicleColour, licensePlateNumber, hasPassenger);
            default:
                return new Bus(vehicleColour, licensePlateNumber, hasPassenger);
        }
    }
    
    static void Main(string[] args)
    {
        var random = new Random();
        var checkPoint = new CheckPoint();

        Console.Write("\nЗапуск Контрольного Пункта..\n");
        while (!Console.KeyAvailable)
        {
            var vehicle = Generate();

            checkPoint.RegisterVehicle(vehicle);
            Thread.Sleep(random.Next(500, 5001));
        }
        
        checkPoint.PrintStatistics();
    }
}


    
