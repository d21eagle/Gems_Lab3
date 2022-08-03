namespace Gems_Lab3;

public class CheckPointStatistics
{
    public int CarsCount { get; set; } 
    public int TrucksCount { get; set; } 
    public int BusesCount { get; set; } 
    public int SpeedLimitBreakersCount { get; set; } 
    public int CarsJackersCount { get; set; }
    public double AverageSpeed { get; set; }

    public void AverageSpeedCount()
    {
        int scoreCount = CarsCount + TrucksCount + BusesCount;
        double avSpeed = AverageSpeed / scoreCount;
        AverageSpeed = Math.Round(avSpeed);
    }
    
    public override string ToString() =>
        "\nСтатистика: \n" +
        "Количество легковых машин: " + CarsCount + ";\n" +
        "Количество грузовых машин: " + TrucksCount + ";\n" +
        "Количество автобусов: " + BusesCount + ";\n" +
        "Количество нарушителей скоростного режима: " + SpeedLimitBreakersCount + ";\n" +
        "Количество угонщиков: " + CarsJackersCount + ";\n" + 
        "Средняя скорость автомобилей: " + AverageSpeed + ";\n";
}