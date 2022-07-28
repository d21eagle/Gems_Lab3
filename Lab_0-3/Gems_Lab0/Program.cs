
namespace Gems_Lab0;

class Program
{
    static void Interface()
    {
        Console.Write("\n>Меню программы<\n");
        Console.Write("(1)Проверка года на високосность\n");
        Console.Write("(2)Конвертер градусов\n");
        Console.Write("(3)Выход\n");
    }
    
    static void IsLeap(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine(year + " - високосный год");
        
        else Console.WriteLine(year + " - невисокосный год");
    }

    static void DegreeConverter(double temp, string scale)
    {
        double celToFah = 0.0;
        double fahToCel = 0.0;
        
        if ((scale == "C") || (scale == "c"))
        {
            celToFah = (temp * 9) / 5 + 32;
            celToFah = Math.Round(celToFah);
            scale = "F";
            Console.Write("Результат: " + celToFah + scale + "\n");
        }
        
        else if ((scale == "F") || (scale == "f"))
        {
            fahToCel = (temp - 32) * 5 / 9;
            fahToCel = Math.Round(fahToCel);
            scale = "C";
            Console.Write("Результат: " + fahToCel + scale + "\n");
        }
    }
    
    static void Main(string[] args)
    {
        int menu;
        do
        {
            Interface();
            Console.Write("\nВыберите действие: ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            switch (menu)
            {
                case 1:
                    int year = 0;
                    Console.Write("Введите год: ");
                    year = Convert.ToInt32(Console.ReadLine());
                    IsLeap(year);
                    break;
                
                case 2:
                    double temp = 0.0;
                    string scale = "";
                    Console.Write("Введите значение температуры: ");
                    temp = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите значение шкалы: ");
                    scale = Console.ReadLine();
                    DegreeConverter(temp, scale);
                    break;
            }
            
        } while (menu != 3);
    }
}