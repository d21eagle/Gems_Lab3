
namespace Gems_Lab3;

class Program
{
    static void InterFace()
    {
        Console.Write("\n>Меню программы<\n");
        Console.Write("(1)Регистрация транспортных средств\n");
        Console.Write("(2)Статистика по типам автомобилей\n");
        Console.Write("(3)Выход\n");
    }

    static void Main(string[] args)
    {
        Console.Write("\n");
        CheckPoint.VehicleGeneration();
    }
}


    
