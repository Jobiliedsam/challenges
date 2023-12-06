namespace ReversePolishNotation.Calculator;

public static class Rpn
{
    public static decimal Calculator(string expression)
    {
        var stack = new Stack<decimal>();
    
        foreach (var tokens in TokenizerRpnExpression(expression))
        {
            var operand = decimal.TryParse(tokens, out decimal number) ? 
                number : 
                PerformOperation(tokens, stack);
            
            stack.Push(operand);
        }
        
        return stack.Pop();
    }
    
    private static string[] TokenizerRpnExpression(string expression) => 
        expression.Split(' ');

    static decimal PerformOperation(string @operator, Stack<decimal> numbers) =>
        @operator switch
        {
            "+" => numbers.Pop() + numbers.Pop(),
            "-" => InvertOperands(numbers.Pop(), numbers.Pop(), @operator),
            "*" => numbers.Pop() * numbers.Pop(),
            "/" => InvertOperands(numbers.Pop(), numbers.Pop(), @operator),
            _ => throw new InvalidOperationException()
        };

    static decimal InvertOperands(decimal firstNumber, decimal secondNumber, string @operator) =>
        @operator switch
        {
            "-" => secondNumber - firstNumber,
            "/" => secondNumber / firstNumber,
            _ => throw new InvalidOperationException()
        };
}