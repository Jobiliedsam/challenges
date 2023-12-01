Stack<decimal> stack = new Stack<decimal>();

foreach (var tokens in TokenizerRpnExpression("10 4 3 + 2 * - 2 /"))
{
    if (decimal.TryParse(tokens, out decimal number))
    { 
        stack.Push(number);
        Console.WriteLine($"Add to Stack: [{number}]");
    }
    else
    {
         var operand = PerformOperation(tokens, stack);
         stack.Push(operand);
    }
}

foreach(decimal operand in stack)
    Console.WriteLine(operand);

string[] TokenizerRpnExpression(string expression) => 
    expression.Split(' ');

decimal PerformOperation(string @operator, Stack<decimal> numbers) =>
    @operator switch
    {
        "+" => stack.Pop() + stack.Pop(),
        "-" => InvertOperands(stack.Pop(), stack.Pop(), @operator),
        "*" => stack.Pop() * stack.Pop(),
        "/" => InvertOperands(stack.Pop(), stack.Pop(), @operator),
        _ => throw new InvalidOperationException()
    };

decimal InvertOperands(decimal firstNumber, decimal secondNumber, string @operator) =>
    @operator switch
    {
        "-" => secondNumber - firstNumber,
        "/" => secondNumber / firstNumber,
        _ => throw new InvalidOperationException()
    };
     