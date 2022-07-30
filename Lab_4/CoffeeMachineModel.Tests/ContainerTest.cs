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

    [Fact]
    public void LoadResource_SuccessTest()
    {
        const int expectedValue = 1500;
        var container = new Container(2000);
        container.LoadResource(1000);
        container.LoadResource(500);

        var actualValue = container.GetValue();
        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(700)]
    public void LoadResource_ExceptionTest(int value)
    {
        var container = new Container(2000);
        container.LoadResource(1000);
        container.LoadResource(500);
        Assert.Throws<ArgumentException>(() => container.LoadResource(value));
    }

    [Fact]
    public void GetResource_SuccessTest()
    {
        const int expectedValue = 300;
        var container = new Container(2000);
        container.LoadResource(1000);
        container.LoadResource(500);
        container.GetResource(1200);

        var actualValue = container.GetValue();
        Assert.Equal(expectedValue, actualValue);
    }

    [Theory]
    [InlineData(1500)]
    public void GetResource_ExceptionTest(int value)
    {
        var container = new Container(2000);
        container.LoadResource(1000);
        container.LoadResource(200);
        Assert.Throws<ArgumentException>(() => container.GetResource(value));
    }

    [Fact]
    public void GetCapacityTest()
    {
        const int expectedValue = 2000;
        var container = new Container(2000);

        var actualValue = container.GetCapacity();
        Assert.Equal(expectedValue, actualValue);
    }

    [Fact]
    public void GetValueTest()
    {
        const int expectedValue = 1300;
        var container = new Container(2000);
        container.LoadResource(800);
        container.LoadResource(200);
        container.LoadResource(300);

        var actualValue = container.GetValue();
        Assert.Equal(expectedValue, actualValue);
    }
}