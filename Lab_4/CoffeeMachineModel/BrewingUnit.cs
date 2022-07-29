namespace CoffeeMachineModel;

public class BrewingUnit
{
    public Coffee Brew(int water, int milk, GroundCoffee groundCoffee)
    {
        Coffee coffee = new Coffee();
        coffee.RecipeName.Beans = groundCoffee.Quantity;
        coffee.RecipeName.Water = water;
        coffee.RecipeName.Milk = milk;
        return coffee;
    }
}