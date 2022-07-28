
namespace Gems_Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nЗапуск Контрольного Пункта..\n");
        CheckPointStatistics stat = CheckPoint.GetStatistics();
        Console.Write(stat);
    }
}


    
