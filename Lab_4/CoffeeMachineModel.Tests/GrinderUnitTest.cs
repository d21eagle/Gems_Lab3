using System;
using Xunit;
using CoffeeMachineModel;

namespace CoffeeMachineModel.Tests;

public class GrinderUnitTest
{
    [Fact]
    public void GrindTest()
    {
        var expectedGroundCoffee = new GroundCoffee();
        expectedGroundCoffee.Quantity = 100;
        GrinderUnit grinderUnit = new GrinderUnit();
        var actualGroundCoffee = grinderUnit.Grind(100);
        Assert.True(expectedGroundCoffee.Equals(actualGroundCoffee));
    }
}