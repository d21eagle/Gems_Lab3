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
            IRecorder recorder0 = new ConsoleRecorder(); 
            IRecorder recorder1 = new FileRecorder(@"D:\input.txt");
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
                            var eqHandler = new EquationHandler(recorder0);
                            eqHandler.Handle();
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Нет описания уравнений!");
                        }
                        break;
                    
                    case 2:
                        Console.Clear();
                        try
                        {
                            var eqHandler = new EquationHandler(recorder1);
                            eqHandler.Handle();
                        }
                        catch (FileNotFoundException ex)
                        {
                            Console.WriteLine($"\nПроизошла ошибка: {ex.Message}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Нет описания уравнений!");
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

