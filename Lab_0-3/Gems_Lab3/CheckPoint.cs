using Gems_Lab3.Model;

namespace Gems_Lab3;

public class CheckPoint
{
    private const int SpeedLimit = 110;
    private readonly List<int> _stolenVehicle = new List<int>();
    private readonly CheckPointStatistics _checkPointStatistics = new CheckPointStatistics();

    public void RegisterVehicle(Vehicle vehicle)
    {
        var random = new Random();
        var speed = vehicle.GetSpeed();
        
        for (var i = 0; i < random.Next(30, 101); i++)
            _stolenVehicle.Add(random.Next(100, 1000));

        Console.WriteLine($"Регистрационный номер: {vehicle.LicensePlateNumber}");
        Console.WriteLine($"Скорость: {speed}");
        
        if (vehicle is Car)
        {
            _checkPointStatistics.CarsCount++;
            Console.WriteLine("Легковой автомобиль");
        }
        else if (vehicle is Bus)
        {
            _checkPointStatistics.BusesCount++;
            Console.WriteLine("Автобус");
        }
        else if (vehicle is Truck)
        {
            _checkPointStatistics.TrucksCount++;
            Console.WriteLine("Грузовой автомобиль");
        }

        if (speed > SpeedLimit)
        {
            _checkPointStatistics.SpeedLimitBreakersCount++;
            Console.WriteLine("Нарушение!");
        }

        if (_stolenVehicle.Contains(vehicle.LicensePlateNumber))
        {
            _checkPointStatistics.CarsJackersCount++;
            Console.WriteLine("Перехват!");
        }
        
        _checkPointStatistics.AverageSpeed += speed;
    }

    public void PrintStatistics()
    {
        _checkPointStatistics.AverageSpeedCount();
        Console.WriteLine(_checkPointStatistics);
    }
}