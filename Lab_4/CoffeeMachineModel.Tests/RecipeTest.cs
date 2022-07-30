using System;
using Xunit;
using CoffeeMachineModel;

namespace CoffeeMachineModel.Tests;

public class RecipeTest
{
    [Fact]
    public void RecipeCreateTest()
    {
        Recipe testRecipe = new Recipe(350, 420, 70);
        var actualWater = testRecipe.Water;
        var actualMilk = testRecipe.Milk;
        var actualBeans = testRecipe.Beans;
        Assert.Equal(350, actualWater);
        Assert.Equal(420, actualMilk);
        Assert.Equal(70, actualBeans);
    }
}