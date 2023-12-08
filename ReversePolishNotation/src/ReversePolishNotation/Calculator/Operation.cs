namespace ReversePolishNotation.Calculator;

public static class Operation
{
    public static decimal Perform(string @operator, Stack<decimal> numbers) =>
        @operator switch
        {
            "+" => numbers.Pop() + numbers.Pop(),
            "-" => InvertOperands(numbers.Pop(), numbers.Pop(), @operator),
            "*" => numbers.Pop() * numbers.Pop(),
            "/" => InvertOperands(numbers.Pop(), numbers.Pop(), @operator),
            _ => throw new InvalidOperationException()
        };

    private static decimal InvertOperands(decimal firstNumber, decimal secondNumber, string @operator) =>
        @operator switch
        {
            "-" => secondNumber - firstNumber,
            "/" => secondNumber / firstNumber,
            _ => throw new InvalidOperationException()
        };
}