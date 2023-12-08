namespace ReversePolishNotation.Calculator;

public static class Rpn
{
    public static decimal Calculator(string expression)
    {
        var operandStack = new Stack<decimal>();
    
        foreach (var token in TokenizerRpnExpression(expression))
        {
            var operand = decimal.TryParse(token, out decimal number) ? 
                number : 
                Operation.Perform(token, operandStack);
            
            operandStack.Push(operand);
        }
        
        return operandStack.Pop();
    }

    private static string[] TokenizerRpnExpression(string expression) =>
        expression.Split(' ');
}