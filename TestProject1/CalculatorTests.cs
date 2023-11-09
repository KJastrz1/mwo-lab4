using Microsoft.VisualStudio.TestPlatform.TestHost;
using mwolab4;
using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator cal=new Calculator();
    [Test]
    public void AddTwoIntegers_PositiveNumbers_ReturnsSum()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act
        int result = cal.AddTwoIntegers(num1, num2);

        // Assert
        Assert.AreEqual(30, result);
    }

    [Test]
    public void AddTwoIntegers_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        int num1 = -10;
        int num2 = 20;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => cal.AddTwoIntegers(num1, num2));
    }

    [Test]
    public void AddTwoIntegers_BothNegativeNumbers_ThrowsArgumentException()
    {
        // Arrange
        int num1 = 10;
        int num2 = 20;

        // Act and Assert
        Assert.Throws<ArgumentException>(() => cal.AddTwoIntegers(num1, num2));
    }
}
