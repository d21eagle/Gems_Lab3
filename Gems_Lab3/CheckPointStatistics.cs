namespace Gems_Lab3;

public class CheckPointStatistics
{
    private int CarsCount; // количество легковушек
    private int TrucksCount; // количество грузовиков
    private int BusesCount; // количество автобусов
    private int SpeedLimitBreakersCount; // количество нарушителей скоростного режима
    private int HijackersCount; // количество угонщиков
    private double AverageSpeed; // средняя скорость

    public CheckPointStatistics(int carsCount, int trucksCount, int busesCount, int speedLimitBreakersCount,
            int hijackersCount, double averageSpeed)
    {
        CarsCount = carsCount;
        TrucksCount = trucksCount;
        BusesCount = busesCount;
        SpeedLimitBreakersCount = speedLimitBreakersCount;
        HijackersCount = hijackersCount;
        AverageSpeed = averageSpeed;
    }

    public override string ToString()
    {
        return "\nСтатистика: \n" +
               "Количество легковых машин: " + CarsCount + ";\n" +
               "Количество грузовых машин: " + TrucksCount + ";\n" +
               "Количество автобусов: " + BusesCount + ";\n" +
               "Количество нарушителей скоростного режима: " + SpeedLimitBreakersCount + ";\n" +
               "Количество угонщиков: " + HijackersCount + ";\n" +
               "Средняя скорость автомобилей: " + AverageSpeed + ";\n";
    }
    
}