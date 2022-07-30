namespace CoffeeMachineModel;

public class Coffee
{
    public Recipe RecipeName = new Recipe(0,0,0);
    
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        
        Coffee m = obj as Coffee; 
        if (m as Coffee == null)
            return false;

        return m.RecipeName.Water == this.RecipeName.Water &&
               m.RecipeName.Milk == this.RecipeName.Milk &&
               m.RecipeName.Beans == this.RecipeName.Beans;
    }

    public override string ToString()
    {
        return "\nВаш кофе готов!" + "\n" +
               "Вода: " + RecipeName.Water + " мл." + "\n" +
               "Молоко: " + RecipeName.Milk + " мл." + "\n" +
               "Кофейные зёрна: " + RecipeName.Beans + " г." + "\n";
    }
}