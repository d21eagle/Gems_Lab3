namespace CoffeeMachineModel;

public class GrinderUnit
{
    public GroundCoffee Grind(int quantity)
    {
        var groundCoffee = new GroundCoffee
        {
            Quantity = quantity
        };
        return groundCoffee;
    }
}