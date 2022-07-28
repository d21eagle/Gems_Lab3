using System;
using CoffeeMachineModel;

namespace CoffeeMachineUI
{
    class Program
    {
        static void Interface()
        {
            Console.Write("\n>Меню Кофемашины<\n");
            Console.Write("(1)Эспрессо\n");
            Console.Write("(2)Фильтрованный кофе\n");
            Console.Write("(3)Капучино\n");
            Console.Write("(4)Завершение работы\n");
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
                        Coffee espresso = CoffeeMachine.Brew(CoffeeMachine.RecipeName.Espresso);
                        Console.WriteLine(espresso.ToString());
                        break;
                    
                    case 2:
                        Console.Clear();
                        Coffee filtered = CoffeeMachine.Brew(CoffeeMachine.RecipeName.Filtered);
                        Console.WriteLine(filtered.ToString());
                        break;
                    
                    case 3:
                        Console.Clear();
                        Coffee cappuccino = CoffeeMachine.Brew(CoffeeMachine.RecipeName.Cappuccino);
                        Console.WriteLine(cappuccino.ToString());
                        break;
                }
            
            } while (menu != 4);
        }
    
        static void Main(string[] args)
        {
            Menu();
        }
    }
}

