namespace CoffeeMachineModel;

public class Container
{
    private const int MaxCapacity = 3000;
    private int _capacity;
    private int _value;

    public Container(int capacity)
    {
        if (capacity <= 0 || capacity > MaxCapacity)
            throw new ArgumentException();
        
        _capacity = capacity;
    }

    public void LoadResource(int value)
    {
        if (_value + value > _capacity)
            throw new ArgumentException("Превышена ёмкость контейнера!");

        _value += value;
    }

    public int GetResource(int value)
    {
        if (value > _value) 
            throw new ArgumentException("Недостаточно ресурсов в контейнере!");
        
        _value -= value;
        return value;
    }

    public int GetCapacity() { return _capacity; }

    public int GetValue() { return _value; }
}