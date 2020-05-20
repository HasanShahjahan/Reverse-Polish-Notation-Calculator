using ReversePolishNotation.Calculator.ExpressionEvaluators;
using Xunit;

namespace ReversePolishNotation.Calculator.UnitTest
{
    public class MathematicalExpressionEvaluatorUnitTest
    {
        [Fact]
        public void OneNumberSquareRootCalculations()
        {
            var userInput = "100 √";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("10", answer.ToString());
        }

        [Fact]
        public void OneNumberSquareCalculations()
        {
            var userInput = "10 s";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("100", answer.ToString());
        }

        [Fact]
        public void OneNumberFactorialCalculations()
        {
            var userInput = "5 !";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("120", answer.ToString());
        }

        [Fact]
        public void OneNumberModulusCalculations()
        {
            var userInput = "21 5 %";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("1", answer.ToString());
        }

        [Fact]
        public void TwoNumberCalculations()
        {
            var userInput = "12 3 +";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("15", answer.ToString());
        }

        [Fact]
        public void SriesOfAdditionsAndOrSubtractions()
        {
            var userInput = "12 34 + 56 + 78 - 90 + 12 -";
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
                    answer = null;
                    break;
                }
            }
            Assert.Equal("102", answer.ToString());
        }

    }
}
