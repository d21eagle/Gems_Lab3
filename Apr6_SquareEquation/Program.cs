
namespace Apr6_SquareEquation;

class Program
{
    static void Interface()
    {
        Console.Write("\n>Меню программы<\n");
        Console.Write("(1)Ввод коэффициентов с клавиатуры\n");
        Console.Write("(2)Выход\n");
    }
    
    static void Menu()
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
                    Console.Clear();
                    double a, b, c;
                    Console.Write("Введите, пожалуйста, коэффициенты:\n");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                    c = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\n");
                    
                    try 
                    {
                        Console.Write("Корни уравнения:\n");
                        SquareEquation eq0 = new SquareEquation(a, b, c);
                        double[] res = eq0.SolveSquareEquation();
                        for (int i = 0; i < res.Length; i++)
                            Console.WriteLine("{0:0.00}", res[i]);
                    } 
                    catch (ArgumentException) 
                    {
                        Console.WriteLine("Нет корней!");
                    }
                    break;
            }
            
        } while (menu != 2);
    }
    
    static void Main(string[] args)
    {
        Menu();
    }
}