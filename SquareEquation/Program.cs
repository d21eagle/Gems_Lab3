using Apr6_SquareEquation.Interfaces;
using Apr6_SquareEquation.Recorders;

namespace Apr6_SquareEquation
{
    class Program
    {
        static void Interface()
        {
            Console.Write("\n>Меню программы<\n");
            Console.Write("(1)Ввод коэффициентов с клавиатуры\n");
            Console.Write("(2)Ввод коэффициентов из файла\n");
            Console.Write("(3)Выход\n");
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
                        try
                        {
                            IRecorder recorder = new ConsoleRecorder(); 
                            var eqHandler = new EquationHandler(recorder);
                            eqHandler.Handle();
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Отсутствует описание уравнений!");
                        }
                        break;
                    
                    case 2:
                        Console.Clear();
                        try
                        {
                            IRecorder recorder = new FileRecorder(@"D:\output.txt");
                            var eqHandler = new EquationHandler(recorder);
                            eqHandler.Handle();
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine("Файл не найден!");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Отсутствует описание уравнений!");
                        }
                        break;
                }
            
            } while (menu != 3);
        }
    
        static void Main(string[] args)
        {
            Menu();
        }
    }
}

