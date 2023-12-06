using ReversePolishNotation.Calculator;

namespace ReversePolishNotation.Tests;

public class RpnTests
{
    [Fact]
    public void Should_Sum_Two_Numbers()
    {
        //Arrange
        string expression = "0 1 +";
        
        //Act
        var result = Rpn.Calculator(expression);

        //Assert
        Assert.Equal(1, result);
    }
    
    [Fact]
    public void Should_Subtract_Two_Numbers()
    {
        //Arrange
        string expression = "0 1 -";
        
        //Act
        var result = Rpn.Calculator(expression);

        //Assert
        Assert.Equal(-1, result);
    }
    
    [Fact]
    public void Should_Multiply_Two_Numbers()
    {
        //Arrange
        string expression = "0 1 *";
        
        //Act
        var result = Rpn.Calculator(expression);

        //Assert
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Should_Divide_Two_Numbers()
    {
        //Arrange
        string expression = "0 1 /";
        
        //Act
        var result = Rpn.Calculator(expression);

        //Assert
        Assert.Equal(0, result);
    }
}