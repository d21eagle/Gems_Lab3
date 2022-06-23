namespace Gems_Lab3;

public class CheckPoint
{
    private CheckPointStatistics statistics;
    private static List<int> stolenNumbers;

    /*
    public CheckPointStatistics GetStatistics()
    {
        
    }
    */

    enum Colours { Red, Orange, Yellow, Green, LightBlue, Blue, Violet }

    enum BodyType { Car, Truck, Bus }
    
    enum HasPassenger { True, False }

    public static void RegisterVehicle(Vehicle vehicle)
    {
        if (vehicle.GetSpeed() > 110)
            Console.Write("Превышение скорости!\n");

        /*
        Random r = new Random();
        stolenNumbers.Add(r.Next(100, 1000));

        foreach (var item in stolenNumbers)
        {
            if (vehicle.GetLicensePlateNumber() == item)
                Console.Write("Перехват!");
        }
        */
    }
    
    public static void VehicleGeneration()    
    {
        while (!Console.KeyAvailable)
        {
            // Генерация цветов
            var coloursCount = Enum.GetNames(typeof(Colours)).Length;
            var randColour = (Colours)new Random().Next(coloursCount);
            string colour = randColour.ToString();
        
            // Генерация кузовов
            var bodyTypeCount = Enum.GetNames(typeof(BodyType)).Length;
            var randBodyType = (BodyType)new Random().Next(bodyTypeCount);
            string bodyType = randBodyType.ToString();
        
            // Генерация наличия пассажиров
            var hasPassengerCount = Enum.GetNames(typeof(HasPassenger)).Length;
            var randHasPassenger = (HasPassenger)new Random().Next(hasPassengerCount);
            bool hasPassenger = Convert.ToBoolean(randHasPassenger);
            
            if (randBodyType == BodyType.Car)
            {
                int randSpeed = new Random().Next(90, 151);
                int randNumber = new Random().Next(100, 1000);
                Car car = new Car(colour, bodyType, randNumber, hasPassenger, randSpeed);
                Console.WriteLine(car.ToString());
                RegisterVehicle(car);
            }
            
            if (randBodyType == BodyType.Truck)
            {
                int randSpeed = new Random().Next(70, 101);
                int randNumber = new Random().Next(100, 1000);
                Truck truck = new Truck(colour, bodyType, randNumber, hasPassenger, randSpeed);
                Console.WriteLine(truck.ToString());
                RegisterVehicle(truck);
            }
            
            if (randBodyType == BodyType.Bus)
            {
                int randSpeed = new Random().Next(80, 111);
                int randNumber = new Random().Next(100, 1000);
                Bus bus = new Bus(colour, bodyType, randNumber, hasPassenger, randSpeed);
                Console.WriteLine(bus.ToString());
                RegisterVehicle(bus);
            }

            Random r = new Random();
            Thread.Sleep(r.Next(500, 5001));
        }
        
    }
}