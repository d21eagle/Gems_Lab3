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
            
            Console.Write("\n$Обслуживание$<\n");
            Console.Write("(4)Уровень воды в контейнере\n");
            Console.Write("(5)Уровень молока в контейнере\n");
            Console.Write("(6)Уровень кофейных зёрен в контейнере\n");
            Console.Write("(7)Загрузка/Извлечение ресурсов\n");

            Console.Write("\n(8)Завершение работы\n");
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
            int menu;
            do
            {
                MainInterface();
                Console.Write("\nВыберите действие: ");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        Coffee espresso = CoffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Espresso);
                        Console.WriteLine(espresso.ToString());
                        break;
                    
                    case 2:
                        Console.Clear();
                        Coffee filtered = CoffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Filtered);
                        Console.WriteLine(filtered.ToString());
                        break;
                    
                    case 3:
                        Console.Clear();
                        Coffee cappuccino = CoffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Cappuccino);
                        Console.WriteLine(cappuccino.ToString());
                        break;
                    
                    case 4:
                        Console.Clear();
                        Console.WriteLine(CoffeeMachine.GetWaterLevel());
                        break;
                    
                    case 5:
                        Console.Clear();
                        Console.WriteLine(CoffeeMachine.GetMilkLevel());
                        break;
                    
                    case 6:
                        Console.Clear();
                        Console.WriteLine(CoffeeMachine.GetBeansLevel());
                        break;
                    
                    case 7:
                        Console.Clear();
                        int tick;
                        do
                        {
                            LoadGetInterface();
                            Console.Write("\nВыберите действие: ");
                            tick = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\n");

                            switch (tick)
                            {
                                case 1:
                                    Console.Clear();
                                    CoffeeMachine.LoadByUser(1);
                                    break;
                                
                                case 2:
                                    Console.Clear();
                                    CoffeeMachine.LoadByUser(2);
                                    break;
                                
                                case 3:
                                    Console.Clear();
                                    CoffeeMachine.LoadByUser(3);
                                    break;
                                
                                case 4:
                                    Console.Clear();
                                    CoffeeMachine.GetByUser(1);
                                    break;
                                
                                case 5:
                                    Console.Clear();
                                    CoffeeMachine.GetByUser(2);
                                    break;
                                
                                case 6:
                                    Console.Clear();
                                    CoffeeMachine.GetByUser(3);
                                    break;
                            }
                            
                        } while (tick != 7);
                        break;
                }
            
            } while (menu != 8);
        }
    
        static void Main(string[] args)
        {
            Menu();
        }
    }
}

