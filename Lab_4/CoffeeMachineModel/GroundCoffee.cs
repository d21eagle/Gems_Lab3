namespace CoffeeMachineModel;

public class GroundCoffee
{
    public int Quantity { set; get; }
    
    public override bool Equals(object obj)
    {
        return this.Quantity == ((GroundCoffee)obj).Quantity;
    }
}