using System;
using CoffeeMachineModel;

namespace CoffeeMachineUI
{
    class Program
    {
        static void MainInterface()
        {
            Console.Write("\n>Меню Кофемашины<\n");
            Console.Write("$Кофейная карта$<\n");
            Console.Write("(1)Эспрессо\n");
            Console.Write("(2)Фильтрованный кофе\n");
            Console.Write("(3)Капучино\n");
            Console.Write("(4)Загрузка/Извлечение ресурсов\n");
            Console.Write("(5)Завершение работы\n");
        }

        static void LoadGetInterface()
        {
            Console.Write("\n");
            Console.Write("(1)Загрузка воды\n");
            Console.Write("(2)Загрузка молока\n");
            Console.Write("(3)Загрузка зёрен\n");
            Console.Write("(4)Выгрузка воды\n");
            Console.Write("(5)Выгрузка молока\n");
            Console.Write("(6)Выгрузка зёрен\n");
            Console.Write("(7)Назад\n");
        }
    
        static void Menu()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            int menu;
            do
            {
                Console.WriteLine(coffeeMachine.GetWaterLevel());
                Console.WriteLine(coffeeMachine.GetMilkLevel());
                Console.WriteLine(coffeeMachine.GetBeansLevel());
                MainInterface();
                Console.Write("\nВыберите действие: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Coffee espresso = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Espresso);
                        Console.WriteLine(espresso.ToString());
                        break;
                    
                    case 2:
                        Console.Clear();
                        Coffee filtered = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Filtered);
                        Console.WriteLine(filtered.ToString());
                        break;
                    
                    case 3:
                        Console.Clear();
                        Coffee cappuccino = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Cappuccino);
                        Console.WriteLine(cappuccino.ToString());
                        break;

                    case 4:
                        Console.Clear();
                        int tick;
                        do
                        {
                            Console.WriteLine(coffeeMachine.GetWaterLevel());
                            Console.WriteLine(coffeeMachine.GetMilkLevel());
                            Console.WriteLine(coffeeMachine.GetBeansLevel());
                            LoadGetInterface();
                            Console.Write("\nВыберите действие: ");
                            tick = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\n");

                            switch (tick)
                            {
                                case 1:
                                    Console.Clear();
                                    coffeeMachine.LoadByUser(1);
                                    break;
                                
                                case 2:
                                    Console.Clear();
                                    coffeeMachine.LoadByUser(2);
                                    break;
                                
                                case 3:
                                    Console.Clear();
                                    coffeeMachine.LoadByUser(3);
                                    break;
                                
                                case 4:
                                    Console.Clear();
                                    coffeeMachine.GetByUser(1);
                                    break;
                                
                                case 5:
                                    Console.Clear();
                                    coffeeMachine.GetByUser(2);
                                    break;
                                
                                case 6:
                                    Console.Clear();
                                    coffeeMachine.GetByUser(3);
                                    break;
                            }
                            
                        } while (tick != 7);
                        break;
                }
            
            } while (menu != 5);
        }
    
        static void Main(string[] args)
        {
            Menu();
        }
    }
}

