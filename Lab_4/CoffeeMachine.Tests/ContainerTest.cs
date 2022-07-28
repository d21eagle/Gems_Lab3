using System;
using Xunit;
using Container = CoffeeMachineModel.Container;

namespace CoffeeMachine.Tests;

public class ContainerTest
{
    [Fact]
    public void ContainerCapacitySet_Success()
    {
        // Arrange
        const int expectedCapacity = 1000;
        var container = new Container(expectedCapacity);
        // Act
        var actualCapacity = container.GetCapacity();
        // Assert
        Assert.Equal(expectedCapacity, actualCapacity);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(3001)]
    public void ContainerInvalidCapacity_ThrowsException(int capacity)
    {
        // Act + Assert
        Assert.Throws<ArgumentException>(() => new Container(capacity));
    }
    
}