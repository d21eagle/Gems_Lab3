namespace CoffeeMachineModel;

public static class CoffeeMachine
{
    private static Dictionary<RecipeName, Recipe> _recipes = null!;
    private static GrinderUnit _grinderUnit = new GrinderUnit();
    private static BrewingUnit _brewingUnit = new BrewingUnit();
    private static Container _waterContainer = new Container(3000);
    private static Container _milkContainer = new Container(3000);
    private static Container _beansContainer = new Container(3000);
    
    public enum RecipeName { Espresso, Filtered, Cappuccino }

    public static Coffee BrewCoffee(RecipeName recipe)
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

        try
        {
            water = _waterContainer.GetResource(recipes.Water);
        }
        catch (ArgumentException)
        {
            do
            {
                Console.WriteLine("\nНекорректное количество воды!");
                Console.Write("Введите количество ресурса:\n");
                water = Convert.ToInt32(Console.ReadLine());
            } while (water + _waterContainer.GetValue() < recipes.Water || 
                     water + _waterContainer.GetValue() > _waterContainer.GetCapacity());

            _waterContainer.LoadResource(water);
            water = _waterContainer.GetResource(recipes.Water);
        }

        try
        {
            milk = _milkContainer.GetResource(recipes.Milk);
        }
        catch (ArgumentException)
        {
            do
            {
                Console.WriteLine("\nНекорректное количество молока!");
                Console.Write("Введите количество ресурса:\n");
                milk = Convert.ToInt32(Console.ReadLine());
            } while (milk + _milkContainer.GetValue() < recipes.Milk || 
                     milk + _milkContainer.GetValue() > _milkContainer.GetCapacity());
            
            _milkContainer.LoadResource(milk);
            milk = _milkContainer.GetResource(recipes.Milk);
        }
        
        try
        {
            beans = _beansContainer.GetResource(recipes.Beans);
        }
        catch (ArgumentException)
        {
            do
            {
                Console.WriteLine("\nНекорректное количество кофейных зёрен!");
                Console.Write("Введите количество ресурса:\n");
                beans = Convert.ToInt32(Console.ReadLine());
            } while (beans + _beansContainer.GetValue() < recipes.Beans || 
                     beans + _beansContainer.GetValue() > _beansContainer.GetCapacity());
            
            _beansContainer.LoadResource(beans);
            beans = _beansContainer.GetResource(recipes.Beans);
        }
        
        GroundCoffee grind = _grinderUnit.Grind(beans);
        Coffee coffee = _brewingUnit.Brew(water, milk, grind);
        return coffee;
    }

    public static void LoadWater()
    {
        int water = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            water = Convert.ToInt32(Console.ReadLine());
        } while (water + _waterContainer.GetValue() > _waterContainer.GetCapacity());
        _waterContainer.LoadResource(water);
    }
    
    public static void LoadMilk()
    {
        int milk = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            milk = Convert.ToInt32(Console.ReadLine());
        } while (milk + _milkContainer.GetValue() > _milkContainer.GetCapacity());
        _milkContainer.LoadResource(milk);
    }
    
    public static void LoadBeans()
    {
        int beans = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            beans = Convert.ToInt32(Console.ReadLine());
        } while (beans + _beansContainer.GetValue() > _beansContainer.GetCapacity());
        _beansContainer.LoadResource(beans);
    }

    public static void GetWater()
    {
        int water = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            water = Convert.ToInt32(Console.ReadLine());
        } while (water > _waterContainer.GetValue());
        _waterContainer.GetResource(water);
    }
    
    public static void GetMilk()
    {
        int milk = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            milk = Convert.ToInt32(Console.ReadLine());
        } while (milk > _milkContainer.GetValue());
        _milkContainer.GetResource(milk);
    }
    
    public static void GetBeans()
    {
        int beans = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            beans = Convert.ToInt32(Console.ReadLine());
        } while (beans > _beansContainer.GetValue());
        _beansContainer.GetResource(beans);
    }

    public static string GetWaterLevel()
    {
        return "\nУровень воды в контейнере: " + _waterContainer.GetValue() + " мл.";
    }

    public static string GetMilkLevel()
    {
        return "\nУровень молока в контейнере: " + _milkContainer.GetValue() + " мл.";
    }

    public static string GetBeansLevel()
    {
        return "\nУровень кофейных зёрен в контейнере: " + _beansContainer.GetValue() + " г.";
    }
}