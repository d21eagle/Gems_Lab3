namespace CoffeeMachineModel;

public class BrewingUnit
{
    public Coffee Brew(GroundCoffee groundCoffee)
    {
        Coffee coffee = new Coffee();
        coffee.RecipeName.Beans = groundCoffee.Quantity;
        return coffee;
    }
}