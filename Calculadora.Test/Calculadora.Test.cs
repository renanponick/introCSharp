using Xunit;

public class CalculatorTests
{

    Programa.Calculadora calculadora = new Programa.Calculadora();

    [Fact]
    public void TestAddition()
    {
        // Arrange
        double a = 2;
        double b = 3;
        double expectedSum = 5;

        // Act
        double result = calculadora.Somar(a, b);

        // Assert
        Assert.Equal(expectedSum, result);
    }
}
