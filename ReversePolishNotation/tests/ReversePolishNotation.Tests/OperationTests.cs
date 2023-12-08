using ReversePolishNotation.Calculator;

namespace ReversePolishNotation.Tests;

public class OperationTests
{
    [Theory]
    [InlineData("+", 0, 1, 1)]
    [InlineData("-", 0, 1, -1)]
    [InlineData("*", 0, 1, 0)]
    [InlineData("/", 0, 1, 0)]
    public void Should_Perform_Operations_With_Basic_Values(string @operator, 
        decimal firstNumber, 
        decimal secondNumber, 
        decimal expectedResult)
    {
        //Arrange
        Stack<decimal> stack = new(new[] { firstNumber, secondNumber });
        
        //Act
        var result = Operation.Perform(@operator, stack);
        
        //Assert
        Assert.Equal(expectedResult, result);
    }
}