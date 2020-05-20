using ReversePolishNotation.Calculator.ExpressionEvaluators;
using System;

namespace ReversePolishNotation.Calculator
{
    public class CommandLineInterface
    {
        const string _welcomeString = "Welcome to Roon Labs Calculator, a basic" + " calculator using Reverse Polish notation.\nPress ? followed by enter" + " for help and a list of available operators.\n\n";
        const string _promptString = "Input: ";
        const string _answerString = "Answer: {0}\n\n";
        const string _errorString = "Unexpected operator: {0}\n" + "Please press ? followed by enter for available operators.\n";
        const string _helpString = "Operands are placed before operators, such as 5 7 + to add 5 and 7.\n\n" +
            "Available operators:";
        
        public double Begin()
        {
            Console.Write(_welcomeString);

            for (; ; )
            {
                Console.Write(_promptString);

                var userInput = Console.ReadLine();
                if (userInput.Contains('?'))
                {
                    Console.WriteLine(_helpString);
                    foreach (var key in MathematicalExpressionEvaluator.ExpressionEvaluators.Keys)
                    {
                        Console.Write("{0} ", key);
                    }
                    Console.WriteLine("\n");
                }

                var inputStatement = new MathematicalExpressionStatement(userInput);
                double? answer = null;

                foreach (var expression in inputStatement.Expressions)
                {
                    if (MathematicalExpressionEvaluator.ExpressionEvaluators.ContainsKey(expression.Operator))
                    {
                        answer = MathematicalExpressionEvaluator.ExpressionEvaluators[expression.Operator](expression, answer);
                    }
                    else
                    {
                        Console.WriteLine(_errorString, expression.Operator);
                        answer = null;
                        break;
                    }
                }

                if (answer.HasValue)
                {
                    Console.Write(_answerString, answer);
                }
            }
        }
    }
}