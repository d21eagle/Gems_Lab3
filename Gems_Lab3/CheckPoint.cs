namespace Gems_Lab3;

public class CheckPoint
{
    enum Colours { Red, Orange, Yellow, Green, LightBlue, Blue, Violet }

    enum BodyType { Car, Truck, Bus }
    
    enum HasPassenger { True, False }

    public static int RegisterVehicle(Vehicle vehicle)
    {
        if (vehicle.GetSpeed() > 110)
            return 1;
        
        // Заполнение списка угнанных машин 
        
        int fill = 100; // допустим, 100 номеров в розыске
        List<int> stolenNumbers = new List<int>();
        while (fill-- > 0)
        {
            Random r = new Random();
            stolenNumbers.Add(r.Next(100, 1000));
        }

        foreach (var item in stolenNumbers)
        {
            if (vehicle.GetLicensePlateNumber() == item)
                return 2;
        }

        return 0;
    }
    
    public static CheckPointStatistics GetStatistics()
    {
        int carsCount = 0;
        int trucksCount = 0;
        int busesCount = 0;

        int carSumSpeed = 0;
        int truckSumSpeed = 0;
        int busSumSpeed = 0;

        int breakersCount = 0;
        int jackersCount = 0;

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
                if (RegisterVehicle(car) == 1)
                {
                    Console.Write("Превышение скорости!\n");
                    breakersCount++;
                }
                if (RegisterVehicle(car) == 2)
                {
                    Console.Write("Перехват!\n");
                    jackersCount++;
                }
                carsCount++;
                carSumSpeed += randSpeed;
            }
            
            if (randBodyType == BodyType.Truck)
            {
                int randSpeed = new Random().Next(70, 101);
                int randNumber = new Random().Next(100, 1000);
                Truck truck = new Truck(colour, bodyType, randNumber, hasPassenger, randSpeed);
                Console.WriteLine(truck.ToString());
                if (RegisterVehicle(truck) == 1)
                {
                    Console.Write("Превышение скорости!\n");
                    breakersCount++;
                }
                if (RegisterVehicle(truck) == 2)
                {
                    Console.Write("Перехват!\n");
                    jackersCount++;
                }
                trucksCount++;
                truckSumSpeed += randSpeed;
            }
            
            if (randBodyType == BodyType.Bus)
            {
                int randSpeed = new Random().Next(80, 111);
                int randNumber = new Random().Next(100, 1000);
                Bus bus = new Bus(colour, bodyType, randNumber, hasPassenger, randSpeed);
                Console.WriteLine(bus.ToString());
                if (RegisterVehicle(bus) == 1)
                {
                    Console.Write("Превышение скорости!\n");
                    breakersCount++;
                }
                if (RegisterVehicle(bus) == 2)
                {
                    Console.Write("Перехват!\n");
                    jackersCount++;
                }
                busesCount++;
                busSumSpeed += randSpeed;
            }

            Random r = new Random();
            Thread.Sleep(r.Next(500, 5001));
        }

        int scoreSpeed = carSumSpeed + truckSumSpeed + busSumSpeed;
        int scoreCount = carsCount + trucksCount + busesCount;
        double avSpeed = (double)scoreSpeed / scoreCount;
        avSpeed = Math.Round(avSpeed);
        
        CheckPointStatistics stat = new CheckPointStatistics(carsCount, trucksCount, busesCount, 
            breakersCount, jackersCount, avSpeed);

        return stat;
    }
}