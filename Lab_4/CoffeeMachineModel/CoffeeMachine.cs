namespace CoffeeMachineModel;

public static class CoffeeMachine
{
    private static Dictionary<RecipeName, Recipe> _recipes = null!;
    private static GrinderUnit _grinderUnit = null!;
    private static BrewingUnit _brewingUnit = null!;
    private static Container _waterContainer = null!;
    private static Container _milkContainer = null!;
    private static Container _beansContainer = null!;
    
    public enum RecipeName { Espresso, Filtered, Cappuccino }

    public static int ResourceInput()
    {
        int value = 0;
        do
        {
            Console.Write("Введите количество ресурса:\n");
            value = Convert.ToInt32(Console.ReadLine());
        } while (value <= 0);

        return value;
    }

    public static Coffee Brew(RecipeName recipe)
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
            _waterContainer = new Container(3000);
            water = _waterContainer.GetResource(recipes.Water);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Недостаточно воды в контейнере!");
            water = ResourceInput();
            LoadWater(water);
            water = _waterContainer.GetResource(recipes.Water);
        }

        try
        {
            _milkContainer = new Container(3000);
            milk = _milkContainer.GetResource(recipes.Milk);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Недостаточно молока в контейнере!");
            milk = ResourceInput();
            LoadMilk(milk);
            milk = _milkContainer.GetResource(recipes.Milk);
        }

        try
        {
            _beansContainer = new Container(3000);
            beans = _beansContainer.GetResource(recipes.Beans);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Недостаточно кофейных зёрен в контейнере!");
            beans = ResourceInput();
            LoadBeans(beans);
            beans = _beansContainer.GetResource(recipes.Beans);
        }

        _grinderUnit = new GrinderUnit();
        _brewingUnit = new BrewingUnit();
        GroundCoffee grind = _grinderUnit.Grind(beans);
        Coffee coffee = _brewingUnit.Brew(grind);
        coffee.RecipeName.Water = water;
        coffee.RecipeName.Milk = milk;
        return coffee;
    }

    public static void LoadWater(int value)
    {
        try
        {
            _waterContainer.LoadResource(value);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    
    public static void LoadMilk(int value)
    {
        try
        {
            _milkContainer.LoadResource(value);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    
    public static void LoadBeans(int value)
    {
        try
        {
            _beansContainer.LoadResource(value);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static int GetWaterLevel()
    {
        return _waterContainer.GetValue();
    }

    public static int GetMilkLevel()
    {
        return _milkContainer.GetValue();
    }

    public static int GetBeansLevel()
    {
        return _beansContainer.GetValue();
    }
}