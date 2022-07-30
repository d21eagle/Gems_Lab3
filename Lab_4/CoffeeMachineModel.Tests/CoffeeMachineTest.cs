using CoffeeMachineModel;
using Xunit;
using CoffeeMachine = CoffeeMachineModel.CoffeeMachine;

namespace CoffeeMachineModel.Tests;

public class CoffeeMachineTest
{   
    CoffeeMachine coffeeMachine = new CoffeeMachine();
    Container waterContainer = new Container(3000); 
    Container milkContainer = new Container(3000);
    Container beansContainer = new Container(3000);
    
    [Fact]
    public void BrewCoffeeEspresso_Test()
    {
        Coffee expected = new Coffee();
        expected.RecipeName.Water = 350;
        expected.RecipeName.Milk = 0;
        expected.RecipeName.Beans = 70;
        waterContainer.LoadResource(2000);
        milkContainer.LoadResource(2000);
        beansContainer.LoadResource(2000);
        coffeeMachine.SetWaterContainer(waterContainer);
        coffeeMachine.SetMilkContainer(milkContainer);
        coffeeMachine.SetBeansContainer(beansContainer);
        
        Coffee actual = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Espresso);
        Assert.True(expected.Equals(actual));
    }
    
    [Fact]
    public void BrewCoffeeFiltered_Test()
    {
        Coffee expected = new Coffee();
        expected.RecipeName.Water = 1500;
        expected.RecipeName.Milk = 0;
        expected.RecipeName.Beans = 90;
        waterContainer.LoadResource(2000);
        milkContainer.LoadResource(2000);
        beansContainer.LoadResource(2000);
        coffeeMachine.SetWaterContainer(waterContainer);
        coffeeMachine.SetMilkContainer(milkContainer);
        coffeeMachine.SetBeansContainer(beansContainer);
        
        Coffee actual = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Filtered);
        Assert.True(expected.Equals(actual));
    }
    
    [Fact]
    public void BrewCoffeeCappuccino_Test()
    {
        Coffee expected = new Coffee();
        expected.RecipeName.Water = 350;
        expected.RecipeName.Milk = 420;
        expected.RecipeName.Beans = 70;
        waterContainer.LoadResource(2000);
        milkContainer.LoadResource(2000);
        beansContainer.LoadResource(2000);
        coffeeMachine.SetWaterContainer(waterContainer);
        coffeeMachine.SetMilkContainer(milkContainer);
        coffeeMachine.SetBeansContainer(beansContainer);
        
        Coffee actual = coffeeMachine.BrewCoffee(CoffeeMachine.RecipeName.Cappuccino);
        Assert.True(expected.Equals(actual));
    }

    [Fact]
    public void GetResourcesLevel_Test()
    {
        waterContainer.LoadResource(1500);
        milkContainer.LoadResource(800);
        beansContainer.LoadResource(2300);
        coffeeMachine.SetWaterContainer(waterContainer);
        coffeeMachine.SetMilkContainer(milkContainer);
        coffeeMachine.SetBeansContainer(beansContainer);
        string expected1 = "Уровень воды в контейнере: 1500 мл.";
        string expected2 = "Уровень молока в контейнере: 800 мл.";
        string expected3 = "Уровень кофейных зёрен в контейнере: 2300 г.";

        string actual1 = coffeeMachine.GetWaterLevel();
        string actual2 = coffeeMachine.GetMilkLevel();
        string actual3 = coffeeMachine.GetBeansLevel();
        
        Assert.Equal(expected1, actual1);
        Assert.Equal(expected2, actual2);
        Assert.Equal(expected3, actual3);
    }
}