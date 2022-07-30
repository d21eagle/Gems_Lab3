using System;
using Xunit;
using CoffeeMachineModel;

namespace CoffeeMachineModel.Tests;

public class BrewingUnitTest
{
    [Fact]
    public void BrewTest()
    {
        Coffee expectedCoffee = new Coffee();
        expectedCoffee.RecipeName.Water = 350;
        expectedCoffee.RecipeName.Milk = 420;
        expectedCoffee.RecipeName.Beans = 70;
        var groundCoffee = new GroundCoffee();
        groundCoffee.Quantity = 70;
        BrewingUnit brewingUnit = new BrewingUnit();
        var actualCoffee = brewingUnit.Brew(350, 420, groundCoffee);
        Assert.True(expectedCoffee.Equals(actualCoffee));
    }
}