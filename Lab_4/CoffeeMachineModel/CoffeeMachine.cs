namespace CoffeeMachineModel;

public class CoffeeMachine
{
    private Dictionary<RecipeName, Recipe> _recipes = null!;
    private GrinderUnit _grinderUnit = new GrinderUnit();
    private BrewingUnit _brewingUnit = new BrewingUnit();
    private Container _waterContainer = new Container(3000);
    private Container _milkContainer = new Container(3000);
    private Container _beansContainer = new Container(3000);
    
    public enum RecipeName { Espresso, Filtered, Cappuccino }

    public Coffee BrewCoffee(RecipeName recipe)
    {
        int water = 0;
        int milk = 0;
        int beans = 0;
        _recipes = new Dictionary<RecipeName, Recipe>();
        Recipe recipes = new Recipe(0, 0, 0);
        
        _recipes.Add(RecipeName.Espresso, new Recipe(350, 0, 70));
        _recipes.Add(RecipeName.Filtered, new Recipe(1500, 0, 90));
        _recipes.Add(RecipeName.Cappuccino, new Recipe(350, 420, 70));

        if (recipe == RecipeName.Espresso)
            recipes = _recipes[RecipeName.Espresso];

        if (recipe == RecipeName.Filtered)
            recipes = _recipes[RecipeName.Filtered];

        if (recipe == RecipeName.Cappuccino)
            recipes = _recipes[RecipeName.Cappuccino];
       
        while(true)
            try
            {
                water = _waterContainer.GetResource(recipes.Water);
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nНедостаточно воды в контейнере!");
                while (true)
                    try
                    {
                        Console.Write("Введите количество воды:\n");
                        water = int.Parse(Console.ReadLine()!);
                        if (water + _waterContainer.GetValue() >= recipes.Water) 
                            _waterContainer.LoadResource(water);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nКонтейнер предназначен только для воды!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("\nСлишком много воды в контейнере!");
                    }
            }

        while(true)
            try
            {
                milk = _milkContainer.GetResource(recipes.Milk);
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nНедостаточно молока в контейнере!");
                while (true)
                    try
                    {
                        Console.Write("Введите количество молока:\n");
                        milk = int.Parse(Console.ReadLine()!);
                        if (milk + _milkContainer.GetValue() >= recipes.Milk) 
                            _milkContainer.LoadResource(milk);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nКонтейнер предназначен только для молока!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("\nСлишком много молока в контейнере!");
                    }
            }
        
        while(true)
            try
            {
                beans = _beansContainer.GetResource(recipes.Beans);
                break;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nНедостаточно зёрен в контейнере!");
                while (true)
                    try
                    {
                        Console.Write("Введите количество зёрен:\n");
                        beans = int.Parse(Console.ReadLine()!);
                        if (beans + _beansContainer.GetValue() >= recipes.Beans) 
                            _beansContainer.LoadResource(beans);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nКонтейнер предназначен только для зёрен!");
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("\nСлишком много зёрен в контейнере!");
                    }
            }
        
        GroundCoffee grind = _grinderUnit.Grind(beans);
        Coffee coffee = _brewingUnit.Brew(water, milk, grind);
        return coffee;
    }

    public void LoadByUser(int resNum)
    {
        int value = 0;
        
        while(true)
            try
            {
                Console.Write("Введите количество ресурса:\n");
                value = int.Parse(Console.ReadLine()!);
                if (resNum == 1) _waterContainer.LoadResource(value);
                if (resNum == 2) _milkContainer.LoadResource(value);
                if (resNum == 3) _beansContainer.LoadResource(value);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nКонтейнер не предназначен для этого ресурса!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
    }

    public void GetByUser(int resNum)
    {
        int value = 0;
        
        while(true)
            try
            {
                Console.Write("Введите количество ресурса:\n");
                value = int.Parse(Console.ReadLine()!);
                if (resNum == 1) _waterContainer.GetResource(value);
                if (resNum == 2) _milkContainer.GetResource(value);
                if (resNum == 3) _beansContainer.GetResource(value);
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nКонтейнер не предназначен для этого ресурса!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
    }

    public string GetWaterLevel()
    {
        return "Уровень воды в контейнере: " + _waterContainer.GetValue() + " мл.";
    }

    public string GetMilkLevel()
    {
        return "Уровень молока в контейнере: " + _milkContainer.GetValue() + " мл.";
    }

    public string GetBeansLevel()
    {
        return "Уровень кофейных зёрен в контейнере: " + _beansContainer.GetValue() + " г.";
    }

    public void SetWaterContainer(Container waterContainer)
    {
        _waterContainer = waterContainer;
    }
    
    public void SetMilkContainer(Container milkContainer)
    {
        _milkContainer = milkContainer;
    }
    
    public void SetBeansContainer(Container beansContainer)
    {
        _beansContainer = beansContainer;
    }
}