namespace CoffeeMachineModel;

public class Coffee
{
    public Recipe RecipeName = new Recipe(0,0,0);

    public override string ToString()
    {
        return "\nВаш кофе готов!" + "\n" +
               "Текущий уровень воды: " + RecipeName.Water + " г." + "\n" +
               "Текущий уровень молока: " + RecipeName.Milk + " г." + "\n" +
               "Текущий уровень кофейные зёрен: " + RecipeName.Beans + " г." + "\n";
    }
}