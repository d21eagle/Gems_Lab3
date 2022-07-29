namespace CoffeeMachineModel;

public class Coffee
{
    public Recipe RecipeName = new Recipe(0,0,0);

    public override string ToString()
    {
        return "\nВаш кофе готов!" + "\n" +
               "Оставшийся уровень воды: " + RecipeName.Water + " мл." + "\n" +
               "Оставшийся уровень молока: " + RecipeName.Milk + " мл." + "\n" +
               "Оставшийся уровень кофейных зёрен: " + RecipeName.Beans + " г.";
    }
}